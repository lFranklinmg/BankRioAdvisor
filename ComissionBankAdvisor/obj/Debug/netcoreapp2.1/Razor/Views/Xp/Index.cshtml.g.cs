#pragma checksum "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65757ebaf8d503bdfaff472fdc09f81729ddec69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Xp_Index), @"mvc.1.0.view", @"/Views/Xp/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Xp/Index.cshtml", typeof(AspNetCore.Views_Xp_Index))]
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
#line 1 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\_ViewImports.cshtml"
using ComissionBankAdvisor;

#line default
#line hidden
#line 2 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\_ViewImports.cshtml"
using ComissionBankAdvisor.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65757ebaf8d503bdfaff472fdc09f81729ddec69", @"/Views/Xp/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ed2d3f616768cf98cd21a7f60e38c4925f23de1", @"/Views/_ViewImports.cshtml")]
    public class Views_Xp_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Xp>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
  
    ViewData["Title"] = "Comissões XP";

#line default
#line hidden
            BeginContext(72, 61, true);
            WriteLiteral("\r\n<br />\r\n<br />\r\n<br />\r\n<h1 class=\"card-title text-center\">");
            EndContext();
            BeginContext(134, 17, false);
#line 9 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
                              Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(151, 117, true);
            WriteLiteral("</h1>\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <thead>\r\n        <tr class=\"success\">\r\n            <td>");
            EndContext();
            BeginContext(269, 46, false);
#line 14 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientCode));

#line default
#line hidden
            EndContext();
            BeginContext(315, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(339, 44, false);
#line 15 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(383, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(407, 51, false);
#line 16 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AdvisorInitials));

#line default
#line hidden
            EndContext();
            BeginContext(458, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(482, 45, false);
#line 17 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(527, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(551, 42, false);
#line 18 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Market));

#line default
#line hidden
            EndContext();
            BeginContext(593, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(617, 52, false);
#line 19 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GrossIncomeValue));

#line default
#line hidden
            EndContext();
            BeginContext(669, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(693, 52, false);
#line 20 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.GrossLiquidValue));

#line default
#line hidden
            EndContext();
            BeginContext(745, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(769, 51, false);
#line 21 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NetProductValue));

#line default
#line hidden
            EndContext();
            BeginContext(820, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(844, 49, false);
#line 22 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TransferValue));

#line default
#line hidden
            EndContext();
            BeginContext(893, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(917, 47, false);
#line 23 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LiquidValue));

#line default
#line hidden
            EndContext();
            BeginContext(964, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(988, 51, false);
#line 24 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NetAdvisorValue));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1063, 45, false);
#line 25 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BankValue));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1132, 48, false);
#line 26 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.AdvisorValue));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 77, true);
            WriteLiteral("</td>\r\n            <th>Ações</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 31 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1306, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1337, 37, false);
#line 34 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.ClientCode));

#line default
#line hidden
            EndContext();
            BeginContext(1374, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1398, 35, false);
#line 35 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.ClientId));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1457, 42, false);
#line 36 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.AdvisorInitials));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1523, 36, false);
#line 37 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.ProductId));

#line default
#line hidden
            EndContext();
            BeginContext(1559, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1583, 33, false);
#line 38 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.Market));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1640, 51, false);
#line 39 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.GrossIncomeValueFormated));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1715, 51, false);
#line 40 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.GrossLiquidValueFormated));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1790, 50, false);
#line 41 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.NetProductValueFormated));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1864, 48, false);
#line 42 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.TransferValueFormated));

#line default
#line hidden
            EndContext();
            BeginContext(1912, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1936, 46, false);
#line 43 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.LiquidValueFormated));

#line default
#line hidden
            EndContext();
            BeginContext(1982, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2006, 50, false);
#line 44 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.NetAdvisorValueFormated));

#line default
#line hidden
            EndContext();
            BeginContext(2056, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2080, 44, false);
#line 45 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.BankValueFormated));

#line default
#line hidden
            EndContext();
            BeginContext(2124, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2148, 47, false);
#line 46 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
           Write(Html.DisplayFor(x => item.AdvisorValueFormated));

#line default
#line hidden
            EndContext();
            BeginContext(2195, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2236, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46b86c19fc6f4ec6ba6e307a578a449f", async() => {
                BeginContext(2284, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
                                          WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2296, 42, true);
            WriteLiteral("&nbsp;\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 51 "C:\Users\Cartman\source\repos\ComissionBankAdvisor\ComissionBankAdvisor\Views\Xp\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2349, 24, true);
            WriteLiteral("\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Xp>> Html { get; private set; }
    }
}
#pragma warning restore 1591
