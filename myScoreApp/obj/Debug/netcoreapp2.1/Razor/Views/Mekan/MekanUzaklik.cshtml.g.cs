#pragma checksum "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0059b90aed0d85416a1aed49fc883354e130ae5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mekan_MekanUzaklik), @"mvc.1.0.view", @"/Views/Mekan/MekanUzaklik.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mekan/MekanUzaklik.cshtml", typeof(AspNetCore.Views_Mekan_MekanUzaklik))]
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
#line 1 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp;

#line default
#line hidden
#line 2 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp.Models;

#line default
#line hidden
#line 3 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0059b90aed0d85416a1aed49fc883354e130ae5f", @"/Views/Mekan/MekanUzaklik.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb19df36a865842bd55640e009cf94376951932", @"/Views/_ViewImports.cshtml")]
    public class Views_Mekan_MekanUzaklik : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mekan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("300"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml"
  
    ViewData["Title"] = "Uzaklık";

#line default
#line hidden
            BeginContext(70, 51, true);
            WriteLiteral("<div class=\"row  d-flex justify-content-between\">\r\n");
            EndContext();
#line 6 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(162, 83, true);
            WriteLiteral("        <div class=\"card \" style=\"width: 18rem; margin-bottom:30px;\">\r\n            ");
            EndContext();
            BeginContext(245, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65688b41b03643c2acf98a729e4641c8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 276, "~/img/mekan/", 276, 12, true);
#line 9 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml"
AddHtmlAttributeValue("", 288, item.mekanResim, 288, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(352, 78, true);
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(431, 12, false);
#line 11 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml"
                                  Write(item.UrunAdi);

#line default
#line hidden
            EndContext();
            BeginContext(443, 44, true);
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(488, 19, false);
#line 12 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml"
                                Write(item.urunAciklamasi);

#line default
#line hidden
            EndContext();
            BeginContext(507, 24, true);
            WriteLiteral("</p>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 531, "\"", 569, 4);
            WriteAttributeValue("", 538, "/", 538, 1, true);
#line 13 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml"
WriteAttributeValue("", 539, item.user, 539, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 549, "/mekan/", 549, 7, true);
#line 13 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml"
WriteAttributeValue("", 556, item.mekanId, 556, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(570, 78, true);
            WriteLiteral(" class=\"btn btn-primary\">Detaylı Gör</a>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 16 "C:\Users\musta\Desktop\Toplama\18701017_AhmetArifArslan\myScoreApp\Views\Mekan\MekanUzaklik.cshtml"
    }

#line default
#line hidden
            BeginContext(655, 6, true);
            WriteLiteral("</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mekan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
