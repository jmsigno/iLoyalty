#pragma checksum "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5855dc20d99e4d1e1ddebb49fb9657ac4d27f3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Model_Index), @"mvc.1.0.view", @"/Views/Model/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5855dc20d99e4d1e1ddebb49fb9657ac4d27f3c", @"/Views/Model/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"905561c8ac4c35a101d43e8bf6aab857de7534d1", @"/Views/_ViewImports.cshtml")]
    public class Views_Model_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<iLoyalty.Models.CBoxList>
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
#nullable restore
#line 2 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 class=\"text-info\">Build Machine Learning Model</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container row p-0 m-0 border p-3\">\r\n        <div class=\"col-6 border p-3\">\r\n            <h5 class=\"text-info\">Select Data</h5>\r\n            <div>\r\n");
#nullable restore
#line 14 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
                 for (int i = 0; i < Model.cboxlist.Count; i++)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
               Write(Html.CheckBoxFor(m => Model.cboxlist[i].isChecked));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <label class=\"text-info\">\r\n                        ");
#nullable restore
#line 18 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
                   Write(Model.cboxlist[i].boxName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </label>\r\n");
#nullable restore
#line 20 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
               Write(Html.HiddenFor(m => Model.cboxlist[i].boxId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
               Write(Html.HiddenFor(m => Model.cboxlist[i].boxName));

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br />\r\n");
#nullable restore
#line 23 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
        <div class=""col-6 p-3"">
            <h5 class=""text-info"">Model Information</h5>
            <hr />
            <div class=""form-group"">
                <label class=""text-secondary"">Training Period</label>
                <input value=""Select start date"" readonly=""readonly"" class=""form-control datepicker"" />
            </div>
            <div class=""form-group"">
                <input type=""text"" name=""name"" placeholder=""Enter model name...""");
            BeginWriteAttribute("required", " required=\"", 1296, "\"", 1307, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"text\" name=\"creator\" placeholder=\"Enter your name...\"");
            BeginWriteAttribute("required", " required=\"", 1472, "\"", 1483, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"CREATE MODEL\" class=\"btn btn-success\" />\r\n            </div>\r\n            <div>\r\n                <h4 class=\"text-info\">");
#nullable restore
#line 43 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
                                 Write(ViewBag.msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 47 "C:\Users\Jordan\source\repos\iLoyalty\iLoyalty\Views\Model\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5855dc20d99e4d1e1ddebb49fb9657ac4d27f3c7514", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<iLoyalty.Models.CBoxList> Html { get; private set; }
    }
}
#pragma warning restore 1591
