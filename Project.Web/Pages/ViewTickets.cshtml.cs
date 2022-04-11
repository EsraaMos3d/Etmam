using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Project.Core;
using Project.Core.Helper;

namespace Project.Web.Pages
{
    public class ViewTicketsModel : PageModel
    {
        private readonly IUnitOfWork _unitOfWork;
        public ViewTicketsModel(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
           
            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
    public static class QueryExtensions
    {
        public static IQueryable<T> SortBy<T>(this IQueryable<T> source, string propertyName)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }
            if (String.IsNullOrEmpty(propertyName))
            {
                return source;
            }
            // DataSource control passes the sort parameter with a direction
            // if the direction is descending          
            int descIndex = propertyName.IndexOf(" DESC");
            if (descIndex >= 0)
            {
                propertyName = propertyName.Substring(0, descIndex).Trim();
            }
            ParameterExpression parameter = Expression.Parameter(source.ElementType, String.Empty);
            MemberExpression property = Expression.Property(parameter, propertyName);
            LambdaExpression lambda = Expression.Lambda(property, parameter);

            string methodName = (descIndex < 0) ? "OrderBy" : "OrderByDescending";

            Expression methodCallExpression = Expression.Call(typeof(Queryable), methodName,
                                                new Type[] { source.ElementType, property.Type },
                                                source.Expression, Expression.Quote(lambda));

            return source.Provider.CreateQuery<T>(methodCallExpression);
        }
       
        public static IQueryable<T> FilterGenericSearchDataTable<T>(this IQueryable<T> source, DTParameters _tableParams)
        {
            string search = _tableParams.Search?.Value;
            if (String.IsNullOrEmpty(search))
                return source;
            var Props = new List<string>();
            Props.AddRange(_tableParams.Columns.Where(p => p.Searchable == true).Select(s => s.Data).Distinct());
            var searchExpression = Expression.Constant(search.ToLower());
            var paramExpression = Expression.Parameter(typeof(T), "val");
            var _properties = typeof(T).GetProperties().Where(s => Props.Contains(s.Name) /*&& s.PropertyType.FullName == "System.String"*/);



            // invariant expressions
            var conversionLength = Expression.Constant(10, typeof(Nullable<int>));
            var conversionDecimals = Expression.Constant(16, typeof(Nullable<int>));
            List<MethodCallExpression> searchProps = new List<MethodCallExpression>();


            foreach (var property in _properties)
            {
                Expression stringProp = null; //The result must be a TSQL translatable string expression

                var propExp = Expression.Property(paramExpression, property);

                //TODO: find some genius way to categorize numeric properties including their nullable<> variants
                if (new Type[] { typeof(int), typeof(Nullable<int>), typeof(double), typeof(Nullable<double>), typeof(float), typeof(Nullable<float>), typeof(long), typeof(Nullable<long>) }.Contains(property.PropertyType))
                {
                    //var toDoubleCall = Expression.Convert(propExp, typeof(Nullable<double>));

                    //var doubleConvert = typeof(SqlFunctions).GetMethod("StringConvert", new Type[] { typeof(Nullable<double>), typeof(Nullable<int>), typeof(Nullable<int>) });

                    //stringProp = Expression.Call(doubleConvert, toDoubleCall, conversionLength, conversionDecimals);

                }

                if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(Nullable<decimal>))
                {
                    //var toDoubleCall = Expression.Convert(propExp, typeof(Nullable<decimal>));

                    //var doubleConvert = typeof(SqlFunctions).GetMethod("StringConvert", new Type[] { typeof(Nullable<decimal>), typeof(Nullable<int>), typeof(Nullable<int>) });

                    //stringProp = Expression.Call(doubleConvert, toDoubleCall, conversionLength, conversionDecimals);

                }

                //TODO: Provide a way to customize date format
                else if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(Nullable<DateTime>))
                {
                    DateTime dateTime, currentDateTime;
                    CultureInfo arCI = new CultureInfo("ar-SY");
                    bool IsParsedDate = DateTime.TryParse(search, arCI, DateTimeStyles.AllowInnerWhite, out dateTime);
                    if (IsParsedDate)
                    {
                        try
                        {

                            currentDateTime = Convert.ToDateTime(search, arCI);
                            search = currentDateTime.ToString("MM/dd/yyyy");
                            searchExpression = Expression.Constant(search.ToLower());
                        }
                        catch { }
                    }

                    var date = Expression.Convert(propExp, typeof(Nullable<DateTime>));
                    //Only way to get a number for date part
                    var datePart = typeof(Object).GetMethod("DatePart", new Type[] { typeof(string), typeof(Nullable<DateTime>) });
                    //get day of month and year which are already strings
                    var dateName = typeof(Object).GetMethod("DateName", new Type[] { typeof(string), typeof(Nullable<DateTime>) });
                    //Call to get month part
                    var month = Expression.Call(datePart, Expression.Constant("MM"), date);
                    //Convert to double
                    var toDouble = Expression.Convert(month, typeof(Nullable<double>));
                    //convert to string
                    var monthPartToString = typeof(Object).GetMethod("StringConvert", new Type[] { typeof(Nullable<double>) });
                    //now all three numerical parts of date as string
                    var monthPart = Expression.Call(monthPartToString, toDouble);
                    var dayPart = Expression.Call(dateName, Expression.Constant("dd"), date);
                    var yearPart = Expression.Call(dateName, Expression.Constant("yyyy"), date);
                    var conCat4 = typeof(string).GetMethod("Concat", new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) });
                    var conCat2 = typeof(string).GetMethod("Concat", new Type[] { typeof(string), typeof(string) });
                    var delim = Expression.Constant("/");
                    stringProp = Expression.Call(conCat2,
                        Expression.Call(conCat4, monthPart, delim, dayPart, delim), yearPart);

                }

                else if (property.PropertyType == typeof(string))
                {
                    stringProp = propExp;
                }

                if (stringProp != null)
                {
                    searchProps.Add(Expression.Call(stringProp, typeof(string).GetMethod("Contains"), searchExpression));
                }

            }

            var propertyQuery = searchProps.ToArray();
            // we now need to compound the expression by starting with the first
            // expression and build through the iterator
            Expression compoundExpression = propertyQuery[0];

            // add the other expressions
            for (int i = 1; i < propertyQuery.Length; i++)
                compoundExpression = Expression.Or(compoundExpression, propertyQuery[i]);

            // compile the expression into a lambda 
            return source.Where(Expression.Lambda<Func<T, bool>>(compoundExpression, paramExpression));
        }
        public static IQueryable<T> FilterIndividualPropertyDataTable<T>(this IQueryable<T> source, DTParameters _tableParams)
        {
            var paramExpression = Expression.Parameter(typeof(T), "val");
            System.Linq.Expressions.Expression dateAll = null;
            // invariant expressions
            var conversionLength = Expression.Constant(18, typeof(Nullable<int>));
            var conversionDecimals = Expression.Constant(2, typeof(Nullable<int>));
            List<MethodCallExpression> searchProps = new List<MethodCallExpression>();
            foreach (var col in _tableParams.Columns.Where(p => p.Searchable == true).Where(c => c.Search.Value != null))
            {
                string search = col.Search.Value;
                Expression searchExpression = Expression.Constant(col.Search.Value.ToLower());
                var property = typeof(T).GetProperties().FirstOrDefault(s => s.Name == col.Data);


                if (property == null) return null;
                Expression stringProp = null; //The result must be a TSQL translatable string expression
                var propExp = Expression.Property(paramExpression, property);

                //TODO: find some genius way to categorize numeric properties including their nullable<> variants
                if (new Type[] { typeof(int), typeof(Nullable<int>)/*, typeof(double), typeof(Nullable<double>), typeof(float), typeof(Nullable<float>), typeof(long),*/ , typeof(long), typeof(Nullable<long>) }.Contains(property.PropertyType))
                {
                    var toDoubleCall = Expression.Convert(propExp, typeof(Nullable<double>));

                    var doubleConvert = typeof(Object).GetMethod("StringConvert", new Type[] { typeof(Nullable<double>), typeof(Nullable<int>), typeof(Nullable<int>) });

                    stringProp = Expression.Call(doubleConvert, toDoubleCall, conversionLength, conversionDecimals);

                }

                if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(Nullable<decimal>))
                {
                    var toDoubleCall = Expression.Convert(propExp, typeof(Nullable<decimal>));

                    var doubleConvert = typeof(Object).GetMethod("StringConvert", new Type[] { typeof(Nullable<decimal>), typeof(Nullable<int>), typeof(Nullable<int>) });

                    stringProp = Expression.Call(doubleConvert, toDoubleCall, conversionLength, conversionDecimals);

                }

                //TODO: Provide a way to customize date format
                else if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(Nullable<DateTime>))
                {
                    var propertyExpression = Expression.Property(paramExpression, col.Data); //colName 
                    //System.Reflection.MethodInfo containsMethod = null;
                    System.Linq.Expressions.Expression datebody = null;
                    Expression ex1 = null;
                    Expression ex2 = null;
                    DateTime dateTime, currentDateTime;
                    CultureInfo arCI = new CultureInfo("ar-SY");
                    bool IsParsedDate = DateTime.TryParse(col.Search.Value, arCI, DateTimeStyles.AllowInnerWhite, out dateTime);
                    if (IsParsedDate)
                    {
                        try
                        {

                            currentDateTime = Convert.ToDateTime(col.Search.Value, arCI);
                            DateTime nextDate = currentDateTime.AddDays(1);
                            ex1 = Expression.GreaterThanOrEqual(propertyExpression, Expression.Constant(currentDateTime, typeof(DateTime?)));
                            ex2 = Expression.LessThan(propertyExpression, Expression.Constant(nextDate, typeof(DateTime?)));
                            datebody = Expression.AndAlso(ex1, ex2);

                            if (dateAll != null)
                            {
                                dateAll = Expression.And(dateAll, datebody);
                            }
                            else
                            {
                                dateAll = datebody;
                            }
                        }
                        catch
                        {
                            dateAll = datebody;
                        }
                    }
                    else
                    {
                        dateAll = datebody;
                    }
                   

                }

                else if (property.PropertyType == typeof(string))
                {
                    stringProp = propExp;
                }

                if (stringProp != null)
                {
                    searchProps.Add(Expression.Call(stringProp, typeof(string).GetMethod("Contains"), searchExpression));
                }

            }

            var propertyQuery = searchProps.ToArray();
            // we now need to compound the expression by starting with the first
            // expression and build through the iterator
            Expression compoundExpression = Expression.Constant(true);
            if (propertyQuery.Length > 0)
            {
                compoundExpression = propertyQuery[0];

                // add the other expressions
                for (int i = 1; i < propertyQuery.Length; i++)
                    compoundExpression = Expression.And(compoundExpression, propertyQuery[i]);
            }
            // compile the expression into a lambda 


            if (dateAll != null)
                compoundExpression = Expression.And(compoundExpression, dateAll);

            return source.Where(Expression.Lambda<Func<T, bool>>(compoundExpression, paramExpression));
        }

        public static IQueryable<T> FilterForColumn<T>(this IQueryable<T> queryable, string colName, string searchText)
        {
            if (colName != null && searchText != null)
            {
                var parameter = Expression.Parameter(typeof(T), "m");
                var propertyExpression = Expression.Property(parameter, colName);
                //System.Linq.Expressions.ConstantExpression searchExpression = null;
                //System.Reflection.MethodInfo containsMethod = null;
                // this must be of type Expression to accept different type of expressions
                // i.e. BinaryExpression, MethodCallExpression, ...
                System.Linq.Expressions.Expression body = null;
                Expression ex1 = null;
                Expression ex2 = null;
                switch (colName)
                {
                    case "Invoice_Date":
                        DateTime currentDate = DateTime.ParseExact(searchText, "dd/MM/yyyy", null);
                        DateTime nextDate = currentDate.AddDays(1);
                        ex1 = Expression.GreaterThanOrEqual(propertyExpression, Expression.Constant(currentDate, typeof(DateTime?)));
                        ex2 = Expression.LessThan(propertyExpression, Expression.Constant(nextDate, typeof(DateTime?)));
                        body = Expression.AndAlso(ex1, ex2);
                        break;
                }
                var predicate = Expression.Lambda<Func<T, bool>>(body, new[] { parameter });
                return queryable.Where(predicate);
            }
            else
            {
                return queryable;
            }
        }
    }
}
