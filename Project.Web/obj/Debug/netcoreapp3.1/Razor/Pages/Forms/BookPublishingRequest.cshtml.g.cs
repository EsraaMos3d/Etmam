#pragma checksum "E:\Etmam\Project.Web\Pages\Forms\BookPublishingRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7420721d94ca1f9ae735afe02a36b1f5cb5dfd6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.Pages.Forms.Pages_Forms_BookPublishingRequest), @"mvc.1.0.view", @"/Pages/Forms/BookPublishingRequest.cshtml")]
namespace Project.Pages.Forms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Etmam\Project.Web\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Etmam\Project.Web\Pages\_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Etmam\Project.Web\Pages\_ViewImports.cshtml"
using Project.Core.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Etmam\Project.Web\Pages\_ViewImports.cshtml"
using Resources.Resources.Views;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Etmam\Project.Web\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7420721d94ca1f9ae735afe02a36b1f5cb5dfd6f", @"/Pages/Forms/BookPublishingRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58f8cf6d3680557ce1f661907716c2b07913a56", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Forms_BookPublishingRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"boardInfo\">\r\n    <div class=\"row\">\r\n        <div class=\"col-12 grid-margin\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <h4 class=\"card-title\">نموذج طلب نشر كتاب</h4>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7420721d94ca1f9ae735afe02a36b1f5cb5dfd6f4381", async() => {
                WriteLiteral(@"
                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""table infoTable"">
                            <tr>
                                <th>
                                    <label>عنوان الكتاب</label>
                                </th>
                                <th>
                                    <label> موضوعه</label>
                                </th>
                            </tr>
                            <tr>
                                <td data-label="" عنوان الكتاب"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""موضوعه"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                            </tr>
                        </table>

                        <h5 class=""card-description"">
                            بيانات المؤلف/المؤلفين:
    ");
                WriteLiteral(@"                    </h5>
                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""table infoTable"">
                            <tr>
                                <th>
                                    <label>م</label>
                                </th>
                                <th>
                                    <label>اسم المؤلف رباعيا</label>
                                </th>
                                <th>
                                    <label>  الدرجة العلمية</label>
                                </th>
                                <th>
                                    <label>  الكلية</label>
                                </th>
                                <th>
                                    <label>  القسم</label>
                                </th>
                                <th>
                                    <label>  التخصص الدقيق</label>
                                </th>
                   ");
                WriteLiteral(@"         </tr>
                            <tr>
                                <td data-label="" م"">
                                    <label>1</label>
                                </td>
                                <td data-label="" اسم المؤلف رباعيا"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""الدرجة العلمية"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""  الكلية"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""القسم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التخصص الدقيق"">
                                    <inpu");
                WriteLiteral(@"t type=""text"" class=""form-control"">
                                </td>
                            </tr>
                            <tr>
                                <td data-label="" م"">
                                    <label>2</label>
                                </td>
                                <td data-label="" اسم المؤلف رباعيا"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""الدرجة العلمية"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""  الكلية"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""القسم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
           ");
                WriteLiteral(@"                     <td data-label=""التخصص الدقيق"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                            </tr>

                            <tr>
                                <td data-label="" م"">
                                    <label>3</label>
                                </td>
                                <td data-label="" اسم المؤلف رباعيا"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""الدرجة العلمية"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""  الكلية"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""القسم"">
                               ");
                WriteLiteral(@"     <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التخصص الدقيق"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                            </tr>
                            <tr>
                                <td data-label="" م"">
                                    <label>4</label>
                                </td>
                                <td data-label="" اسم المؤلف رباعيا"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""الدرجة العلمية"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""  الكلية"">
                                    <input type=""text"" class=""form-control"">
                                ");
                WriteLiteral(@"</td>
                                <td data-label=""القسم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التخصص الدقيق"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                            </tr>
                        </table>

                        <h5 class=""card-description"">
                            الغرض من تأليف الكتاب:
                        </h5>
                        <div class=""form-group"">
                            <div class=""row"">

                                <div class=""col-12 col-sm-4"">
                                    <div class=""form-check"">
                                        <label class=""form-check-label"">
                                            <input type=""radio"" class=""form-check-input"" name=""optionsRadios"" id=""optionsRadios1"" value=""option1""");
                BeginWriteAttribute("checked", " checked=\"", 7436, "\"", 7446, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            مقرر دراسي
                                            <i class=""input-helper""></i>
                                        </label>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-4"">
                                    <div class=""form-check"">
                                        <label class=""form-check-label"">
                                            <input type=""radio"" class=""form-check-input"" name=""optionsRadios"" id=""optionsRadios2""");
                BeginWriteAttribute("value", " value=\"", 8042, "\"", 8050, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            مرجع علمي
                                            <i class=""input-helper""></i>
                                        </label>
                                    </div>
                                </div>
                                <div class=""col-12 col-sm-4"">
                                    <div class=""form-check"">
                                        <label class=""form-check-label"">
                                            <input type=""radio"" class=""form-check-input"" name=""optionsRadios"" id=""optionsRadios1""");
                BeginWriteAttribute("value", " value=\"", 8645, "\"", 8653, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                            أخري
                                            <i class=""input-helper""></i>
                                        </label>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <h5 class=""card-description"">
                            في حالة الكتاب الدراسي، يرجى استكمال ما يلي:
                        </h5>
                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""table infoTable"">
                            <tr>
                                <th>
                                    <label>رقم المقرر ورمزه</label>
                                </th>
                                <th>
                                    <label> اسم المقرر</label>
                                </th>
                                <th>
                                    <label> عدد الطلبة المتوقع تسجيلهم لهذ");
                WriteLiteral(@"ا المقرر سنويا</label>
                                </th>
                            </tr>
                            <tr>
                                <td data-label="" رقم المقرر ورمزه"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""اسم المقرر"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""عدد الطلبة المتوقع تسجيلهم لهذا المقرر سنويا"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                            </tr>
                        </table>

                        <h5 class=""card-description"">
                            اقرار المؤللفين بالملكية الفكرية للكتاب والتنازل عن حقوق النشر:
                        </h5>
                        <div class=""checkBoxex"">
              ");
                WriteLiteral(@"              <div class=""form-group"">
                                <div class=""form-check form-check-primary"">
                                    <label class=""form-check-label"">
                                        <input type=""checkbox"" class=""form-check-input"">
                                        أقر بملكية الحقوق الفكرية للكتاب دون مشاركة من أحد، وقد أذنت الجامعة السعودية الالكترونية بنشر الكتاب وفق ضوابط النشر المعمول بها في الجامعة وقد أطلعت عليها.
                                    </label>
                                </div>
                                <div class=""form-check form-check-primary"">
                                    <label class=""form-check-label"">
                                        <input type=""checkbox"" class=""form-check-input"">
                                        أقر بملكية الحقوق الفكرية للكتاب بمشاركة المؤلفين المذكورة أسمائهم في الجدول أعلاه، وقد حصلت منهم على الموافقة على نشره وانابتي عنهم في ذلك بناء على توقيع كل منهم أدناه  وقد أذنت الجامع");
                WriteLiteral(@"ة السعودية الالكترونية بنشر الكتاب وفق ضوابط النشر المعمول بها في الجامعة وقد أطلعت عليها.
                                    </label>
                                </div>
                                <div class=""form-check form-check-primary"">
                                    <label class=""form-check-label"">
                                        <input type=""checkbox"" class=""form-check-input"">
                                        أقر بأن الكتاب ليس تحت النظر حاليا لدى أى جهة أخري لغرض النشر
                                    </label>
                                </div>
                                <div class=""form-check form-check-primary"">
                                    <label class=""form-check-label"">
                                        <input type=""checkbox"" class=""form-check-input"">
                                        أتعهد بعدم نشر الكتاب قبل صدور قرار المجلس العلمي بشأن هذا الطلب.
                                    </label>
                              ");
                WriteLiteral(@"  </div>
                                <div class=""form-check form-check-primary"">
                                    <label class=""form-check-label"">
                                        <input type=""checkbox"" class=""form-check-input"">
                                        أقر بأن العمل المقدم ليس له رسالة علمية  (ماجستير - دكتوراه) ،وأنه لم ينشر من قبل.
                                    </label>
                                </div>
                                <div class=""form-check form-check-primary"">
                                    <label class=""form-check-label"">
                                        <input type=""checkbox"" class=""form-check-input"">
                                        أقر بأن العمل المقدم ليس ابحاثا سابقة لي، تم نشرها.
                                    </label>
                                </div>
                                <div class=""form-check form-check-primary"">
                                    <label class=""form-check-label"">
    ");
                WriteLiteral(@"                                    <input type=""checkbox"" class=""form-check-input"">
                                        أقر بأن الكتاب لم يسبق تحكيمه من قبل المجلس العلمي.
                                    </label>
                                </div>
                            </div>
                        </div>

                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""table infoTable mt-3"">
                            <tr>
                                <th>
                                    <label> تم دعم العمل من قبل عمادة البحث العلمي</label>
                                </th>
                                <th>
                                    <label> سنة الدعم</label>
                                </th>
                                <th>
                                    <label>  مبلغ الدعم</label>
                                </th>
                            </tr>
                            <tr>
                              ");
                WriteLiteral(@"  <td class=""checkboxTd"" data-label="" تم دعم العمل من قبل عمادة البحث العلمي"">

                                    <div class=""form-group"">
                                        <div class=""row"">

                                            <div class=""col-12 col-sm-3"">
                                                <div class=""form-check"">
                                                    <label class=""form-check-label"">
                                                        <input type=""radio"" class=""form-check-input"" name=""optionsRadios"" id=""optionsRadios1"" value=""option1""");
                BeginWriteAttribute("checked", " checked=\"", 15395, "\"", 15405, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                        نعم
                                                        <i class=""input-helper""></i>
                                                    </label>
                                                </div>
                                            </div>
                                            <div class=""col-12 col-sm-2"">
                                                <div class=""form-check"">
                                                    <label class=""form-check-label"">
                                                        <input type=""radio"" class=""form-check-input"" name=""optionsRadios"" id=""optionsRadios2""");
                BeginWriteAttribute("value", " value=\"", 16102, "\"", 16110, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                                        لا
                                                        <i class=""input-helper""></i>
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>

                                </td>
                                <td data-label=""سنة الدعم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""  مبلغ الدعم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                            </tr>
                        </table>
                        <h5 class=""card-description"">
                            المؤلفون: (يجب توقيع جميع المؤلفين، وتحديد نسبة المشاركة في ا");
                WriteLiteral(@"لتأليف والتي تحدد نسبة كل مؤلف من المكافأة المقررة)
                        </h5>

                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""table infoTable"">
                            <tr>
                                <th>
                                    <label>م</label>
                                </th>
                                <th>
                                    <label>  الاسم</label>
                                </th>
                                <th>
                                    <label>  التوقيع</label>
                                </th>
                                <th>
                                    <label> نسبة المشاركة في التأليف</label>
                                </th>
                            </tr>
                            <tr>
                                <td data-label="" م"">
                                    <label>1</label>
                                </td>
                          ");
                WriteLiteral(@"      <td data-label=""  الاسم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التوقيع"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""نسبة المشاركة في التأليف"">
                                    <input type=""text"" class=""form-control"" placeholder=""%"">
                                </td>
                            </tr>
                            <tr>
                                <td data-label="" م"">
                                    <label>2</label>
                                </td>
                                <td data-label=""  الاسم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التوقيع"">
                                    <i");
                WriteLiteral(@"nput type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""نسبة المشاركة في التأليف"">
                                    <input type=""text"" class=""form-control"" placeholder=""%"">
                                </td>
                            </tr>
                            <tr>
                                <td data-label="" م"">
                                    <label>3</label>
                                </td>
                                <td data-label=""  الاسم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التوقيع"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""نسبة المشاركة في التأليف"">
                                    <input type=""text"" class=""form-control"" placeholder=""%"">");
                WriteLiteral(@"
                                </td>
                            </tr>
                            <tr>
                                <td data-label="" م"">
                                    <label>4</label>
                                </td>
                                <td data-label=""  الاسم"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التوقيع"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""نسبة المشاركة في التأليف"">
                                    <input type=""text"" class=""form-control"" placeholder=""%"">
                                </td>
                            </tr>

                        </table>


                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""table infoTable"">
                            <tr");
                WriteLiteral(@">
                                <th>
                                    <label>مقدم الطلب</label>
                                </th>
                                <th>
                                    <label>التوقيع</label>
                                </th>
                                <th>
                                    <label>التاريخ</label>
                                </th>
                            </tr>
                            <tr>
                                <td data-label="" مقدم الطلب"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التوقيع"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""التاريخ"">
                                    <input type=""text"" class=""form-control"">
                                </td>
      ");
                WriteLiteral(@"                      </tr>

                            <tr>
                        </table>

                        <table border=""0"" cellspacing=""0"" cellpadding=""0"" class=""table infoTable"">
                            <tr>
                                <th>
                                    <label> &nbsp &nbsp</label>
                                </th>
                                <th>
                                    <label> المدينة</label>
                                </th>
                                <th>
                                    <label>الدولة</label>
                                </th>
                                <th>
                                    <label>الرمز البريدي </label>
                                </th>
                                <th>
                                    <label>رقم الهاتف</label>
                                </th>
                                <th>
                                    <label>البريد ا");
                WriteLiteral(@"لالكتروني</label>
                                </th>
                            </tr>
                            <tr>
                                <td data-label="" عنوان العمل "" class=""FullWidthTd"">
                                    <label>عنوان العمل</label>
                                </td>
                                <td data-label="" المدينة "">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""الدولة"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""الرمز البريدي "">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""رقم الهاتف"">
                                    <input type=""text"" class=""form-control"">
                                <");
                WriteLiteral(@"/td>
                                <td data-label=""البريد الالكتروني"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                            </tr>
                            <tr>
                                <td data-label=""  العنوان الدائم "" class=""FullWidthTd"">
                                    <label>العنوان الدائم </label>
                                </td>
                                <td data-label="" المدينة "">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""الدولة"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""الرمز البريدي "">
                                    <input type=""text"" class=""form-control"">
                                </td>
                               ");
                WriteLiteral(@" <td data-label=""رقم الهاتف"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                                <td data-label=""البريد الالكتروني"">
                                    <input type=""text"" class=""form-control"">
                                </td>
                            </tr>
                        </table>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
