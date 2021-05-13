#pragma checksum "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Cards\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7db4dfc97d3c03277d0fe4f3ed7afa92dffaece"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cards_Index), @"mvc.1.0.view", @"/Views/Cards/Index.cshtml")]
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
#line 1 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\_ViewImports.cshtml"
using BankingProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\_ViewImports.cshtml"
using BankingProject.ApplicationLogic.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7db4dfc97d3c03277d0fe4f3ed7afa92dffaece", @"/Views/Cards/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27784ff01484f2c7b020357b84fbefa54860bf9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Cards_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankingProject.ViewModel.Cards.CompleteCardsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light stretched-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cards", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CardPayments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Cards\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex flex-row flex-wrap justify-content-around\">\r\n");
#nullable restore
#line 33 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Cards\Index.cshtml"
     foreach (var card in Model.Cards)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card details-card\" style=\"width:300px; margin-bottom: 30px;\">\r\n");
            WriteLiteral("            <div class=\"d-flex justify-content-center flex-column\">\r\n                <div class=\"details-card-amount\">");
#nullable restore
#line 41 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Cards\Index.cshtml"
                                            Write(card.Card.OwnerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n                <div class=\"details-card-property-name\">Serial Number:");
#nullable restore
#line 42 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Cards\Index.cshtml"
                                                                 Write(card.Card.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n                <div class=\"details-card-property-name\">Expiry Date:");
#nullable restore
#line 43 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Cards\Index.cshtml"
                                                               Write(card.Card.ExpDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7db4dfc97d3c03277d0fe4f3ed7afa92dffaece6021", async() => {
                WriteLiteral("Go to payments");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Cards\Index.cshtml"
                                                                                                           WriteLiteral(card.Card.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Cards\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankingProject.ViewModel.Cards.CompleteCardsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
