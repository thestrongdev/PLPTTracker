#pragma checksum "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eed918524c6ce1b08d06e5eae70f27e9428db56a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FileUpload_UploadTest), @"mvc.1.0.view", @"/Views/FileUpload/UploadTest.cshtml")]
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
#line 1 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\_ViewImports.cshtml"
using PLPointTrackingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\_ViewImports.cshtml"
using PLPointTrackingSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eed918524c6ce1b08d06e5eae70f27e9428db56a", @"/Views/FileUpload/UploadTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d92b3c6ae730f57aca4b4f09a60b83da80b90d72", @"/Views/_ViewImports.cshtml")]
    public class Views_FileUpload_UploadTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PLPointTrackingSystem.Models.PLM.UploadTestViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/stylesheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eed918524c6ce1b08d06e5eae70f27e9428db56a3970", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div id=\"testUpload\">\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
     if (Model.FileData.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n");
            WriteLiteral(@"        <table>

            <tr>
                <td>Name</td>
                <td>USAPL Member ID</td>
                <td>Age</td>
                <td>Divsions</td>
                <td>Weight Class</td>
                <td>Club</td>
                <td>Gender</td>
            </tr>

");
#nullable restore
#line 28 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
             foreach (var item in @Model.FileData)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
           Write(item.MemberID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
           Write(item.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
           Write(item.DivisionString);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
           Write(item.WeightClass);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
           Write(item.Club);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
           Write(item.Gender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </table>\r\n");
#nullable restore
#line 42 "C:\Users\goods\source\repos\PLPointTrackingSystem\PLPointTrackingSystem\Views\FileUpload\UploadTest.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PLPointTrackingSystem.Models.PLM.UploadTestViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
