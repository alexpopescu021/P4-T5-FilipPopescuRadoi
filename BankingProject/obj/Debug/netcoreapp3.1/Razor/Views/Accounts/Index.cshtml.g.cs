#pragma checksum "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b02b9589d8f2695fa356a6f084efe2216f32d541"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
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
#line 1 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\_ViewImports.cshtml"
using BankingProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\_ViewImports.cshtml"
using BankingProject.ApplicationLogic.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02b9589d8f2695fa356a6f084efe2216f32d541", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27784ff01484f2c7b020357b84fbefa54860bf9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankingProject.ViewModel.Accounts.AccountsListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:16px !important; color:aliceblue"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Accounts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light stretched-link details-card-button "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
  

    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"d-flex justify-content-end\">\r\n\r\n    <div class=\"customer-details-label\">\r\n        Name\r\n    </div>\r\n    <div class=\"customer-details-value\">\r\n        ");
#nullable restore
#line 13 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
   Write(Model.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"d-flex justify-content-end\">\r\n\r\n    <div class=\"customer-details-label\">\r\n        Contact\r\n    </div>\r\n    <div class=\"customer-details-value\">\r\n        ");
#nullable restore
#line 22 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
   Write(Model.PhoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n<div>\r\n    <div class=\"statistics-button\" style=\"width: 200px;height:50px;text-align-last:center\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b02b9589d8f2695fa356a6f084efe2216f32d5416129", async() => {
                WriteLiteral("Create New Bank Account");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<br />\r\n\r\n<div class=\"d-flex flex-row flex-wrap justify-content-around\">\r\n");
#nullable restore
#line 34 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
     foreach (var account in Model.BankAccounts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card details-card\" style=\"width:300px; margin-bottom: 30px;\">\r\n        \r\n");
            WriteLiteral("        \r\n        <div class=\"d-flex justify-content-center flex-column\">\r\n            <div class=\"details-card-amount\">");
#nullable restore
#line 43 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                        Write(account.BankAccount.Balance.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"details-card-currency\">");
#nullable restore
#line 44 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                          Write(account.BankAccount.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"details-card-name\">");
#nullable restore
#line 45 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                      Write(account.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            <div class=\"d-flex flex-row\">\r\n                <div class=\"details-card-property-name\">IBAN</div>\r\n                <div class=\"details-card-property-value\">");
#nullable restore
#line 49 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                    Write(account.BankAccount.IBAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n\r\n            <div class=\"d-flex flex-row\">\r\n                <div class=\"details-card-property-name\">Last Transaction On:</div>\r\n                <div class=\"details-card-property-value\">");
#nullable restore
#line 54 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                    Write(account.BankAccount.LastTransactionDate.ToString("dd/M/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex flex-row\">\r\n                <div class=\"details-card-property-name\">Paid this month:</div>\r\n                <div class=\"details-card-property-value\">");
#nullable restore
#line 58 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                    Write(account.BankAccount.GetAmountPaidInCurrentMonth().ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 58 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                                                                                     Write(account.BankAccount.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        <br>\r\n        <div class=\"d-flex justify-content-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b02b9589d8f2695fa356a6f084efe2216f32d54111081", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 63 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                                WriteLiteral(account.BankAccount.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 67 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankingProject.ViewModel.Accounts.AccountsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
