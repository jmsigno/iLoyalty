#pragma checksum "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "018cd89e007029306148ac631b2bd4b963302a18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DashBoard_Index), @"mvc.1.0.view", @"/Views/DashBoard/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\_ViewImports.cshtml"
using iLoyalty;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\_ViewImports.cshtml"
using iLoyalty.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"018cd89e007029306148ac631b2bd4b963302a18", @"/Views/DashBoard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905561c8ac4c35a101d43e8bf6aab857de7534d1", @"/Views/_ViewImports.cshtml")]
    public class Views_DashBoard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iLoyalty.Models.MLModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/model.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
  
    ViewData["Title"] = "Index";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container m-0 p-0\">\r\n    <h4 class=\"text-info\">Admin Dashboard</h4>\r\n    <div class=\"row border p-3\">\r\n        <div class=\"col-6\">\r\n");
#nullable restore
#line 12 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
             using (Html.BeginForm("Index", "DashBoard", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5 class=\"text-info\">iLoyalty - Ai Models</h5>\r\n                <hr />\r\n                <div>\r\n");
            WriteLiteral("                    ");
#nullable restore
#line 18 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
               Write(Html.DropDownListFor(m => m.id, new SelectList(Model.ListModels, "id", "model_name"), "--Select Model--", new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <br />\r\n                <div>\r\n                    <input type=\"submit\" value=\"PREDICT\" class=\"btn btn-primary\" />\r\n                </div>\r\n");
#nullable restore
#line 24 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-6 pl-5\">\r\n            <div>\r\n                <label class=\"text-info\">Model ID: </label>\r\n                ");
#nullable restore
#line 29 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
           Write(ViewBag.SelectedModelID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <label class=\"text-info\">Model Name: </label>\r\n                ");
#nullable restore
#line 33 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
           Write(ViewBag.SelectedModelName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <label class=\"text-info\">Created By: </label>\r\n                ");
#nullable restore
#line 37 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
           Write(ViewBag.SelectedModelCreator);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                <label class=\"text-info\">Date Created: </label>\r\n                ");
#nullable restore
#line 41 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
           Write(ViewBag.SelectedModelDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"row border p-3\">\r\n        <div class=\"col-12\">\r\n            <h5 class=\"text-info\">Predicted Customers</h5>\r\n            <hr />\r\n");
#nullable restore
#line 49 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
             if (ViewBag.SelectedModelID != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table id=""DT_load"" class=""table table-striped table-bordered"" style=""width:100%"">
                    <thead>
                        <tr>
                            <th>Name</th>
                            <th>Address</th>
                            <th>Phone No</th>
                            <th>Email</th>
                            <th>Churn</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                </table>
");
#nullable restore
#line 63 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\DashBoard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "018cd89e007029306148ac631b2bd4b963302a187869", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iLoyalty.Models.MLModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
