#pragma checksum "E:\Etmam\Project.Web\Pages\CreateTicket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "999809000b6bf2bd1ba3c863ac148fc38b8c01e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Project.Pages.Pages_CreateTicket), @"mvc.1.0.razor-page", @"/Pages/CreateTicket.cshtml")]
namespace Project.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"999809000b6bf2bd1ba3c863ac148fc38b8c01e2", @"/Pages/CreateTicket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d58f8cf6d3680557ce1f661907716c2b07913a56", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_CreateTicket : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "ResultAmendment.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "CvPromotion.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Etmam\Project.Web\Pages\CreateTicket.cshtml"
  
    ViewData["Title"] = "Create Tickets";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"row searchRow\">\r\n\r\n    <div class=\"col-12 col-sm-3\">\r\n        <div class=\"form-group\">\r\n            <label>Select College</label>\r\n");
            WriteLiteral("            ");
#nullable restore
#line 19 "E:\Etmam\Project.Web\Pages\CreateTicket.cshtml"
       Write(Html.DropDownList("FK_College_Id", ViewData["Colleges"] != null ? ViewData["Colleges"] as SelectList : new SelectList(Enumerable.Empty<SelectListItem>()), "select College", new { @class = "form-control has-feedback-left", @id = "College_Id", onchange = "ChangeCollegeList()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-12 col-sm-3\">\r\n        <div class=\"form-group\">\r\n            <label>Select Department</label>\r\n");
            WriteLiteral("            ");
#nullable restore
#line 30 "E:\Etmam\Project.Web\Pages\CreateTicket.cshtml"
       Write(Html.DropDownList("FK_Department_Id", new SelectList(Enumerable.Empty<SelectListItem>()), "select Department", new { @class = "form-control has-feedback-left", @id = "Department_Id" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n    <div class=\"col-12 col-sm-3\">\r\n        <div class=\"form-group\">\r\n            <label>Select Form </label>\r\n            <select class=\"form-control\" onchange=\"ChangeForm(this)\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999809000b6bf2bd1ba3c863ac148fc38b8c01e25793", async() => {
                WriteLiteral("Select Form");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999809000b6bf2bd1ba3c863ac148fc38b8c01e26772", async() => {
                WriteLiteral("\r\n                    Result Amendment Form\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "999809000b6bf2bd1ba3c863ac148fc38b8c01e28006", async() => {
                WriteLiteral("\r\n                    CvPromotion form\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </select>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-12 col-sm-3\">\r\n        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"btn btn-info mr-2\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2363, "\"", 2373, 0);
            EndWriteAttribute();
            WriteLiteral(@">Save</button>
        </div>
    </div>
</div>

<div class=""form"">

</div>

<script>
    function ChangeCollegeList() {
        debugger
        var _College_ID = $(""#College_Id"").val();
        $.ajax({
            type: 'POST',
            url: ""/Home/GetDeptByCollege"",
            data: { College_ID: _College_ID },
            success: function (result) {
                if (result.length > 0) {
                    $(""#Department_Id"").empty()
                    for (var i = 0; i < result.length; i++) {
                        $(""#Department_Id"").append('<option value=""' + result[i].Value + '"">' + result[i].Text + '</option>');
                    }
                }
                else {
                    $(""#Department_Id"").empty().append(""<option>Select Department</option>"");
                }
            }
        });
    }
    function ChangeForm(elem) {
        $.ajax({
            type: 'GET',
            url: ""/Home/GetFormt"",
            data: { PartialName:$(");
            WriteLiteral("elem).val() },\r\n            success: function (result) {\r\n                $(\".form\").html(result);\r\n            }\r\n        });\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project.Web.Pages.CreateTicketModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Web.Pages.CreateTicketModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Project.Web.Pages.CreateTicketModel>)PageContext?.ViewData;
        public Project.Web.Pages.CreateTicketModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
