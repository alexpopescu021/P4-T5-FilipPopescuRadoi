<<<<<<< HEAD
#pragma checksum "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc8925ee1278a3f217105d39085dc746b08185a"
=======
#pragma checksum "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65dd8b6c82caf073b131ea11f000cf68fe465f78"
>>>>>>> parent of 812cdf2 (Merge pull request #8 from alexpopescu021/Alina)
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65dd8b6c82caf073b131ea11f000cf68fe465f78", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27784ff01484f2c7b020357b84fbefa54860bf9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankingProject.ViewModel.Accounts.AccountsListViewModel>
    {
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
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n\r\n<br />\r\n\r\n<div class=\"d-flex flex-row flex-wrap justify-content-around\">\r\n");
#nullable restore
#line 30 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
     foreach (var account in Model.BankAccounts)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card details-card\" style=\"width:300px; margin-bottom: 30px;\">\r\n");
            WriteLiteral("        <div class=\"d-flex justify-content-center flex-column\">\r\n            <div class=\"details-card-amount\">");
#nullable restore
#line 39 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                        Write(account.BankAccount.Balance.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"details-card-currency\">");
#nullable restore
#line 40 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                          Write(account.BankAccount.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"details-card-name\">");
#nullable restore
#line 41 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                      Write(account.CustomerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            <div class=\"d-flex flex-row\">\r\n                <div class=\"details-card-property-name\">IBAN</div>\r\n                <div class=\"details-card-property-value\">");
#nullable restore
#line 45 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                    Write(account.BankAccount.IBAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n\r\n            <div class=\"d-flex flex-row\">\r\n                <div class=\"details-card-property-name\">Last Transaction On:</div>\r\n                <div class=\"details-card-property-value\">");
#nullable restore
#line 50 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                    Write(account.BankAccount.LastTransactionDate.ToString("dd/M/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"d-flex flex-row\">\r\n                <div class=\"details-card-property-name\">Paid this month:</div>\r\n                <div class=\"details-card-property-value\">");
#nullable restore
#line 54 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                    Write(account.BankAccount.GetAmountPaidInCurrentMonth().ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 54 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                                                                                     Write(account.BankAccount.Currency);

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        <br>\r\n        <div class=\"d-flex justify-content-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4fc8925ee1278a3f217105d39085dc746b08185a8983", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 59 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"
                                                                WriteLiteral(account.BankAccount.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n");
=======
            WriteLiteral("</div>\r\n            </div>\r\n        </div>\r\n        <br>\r\n");
            WriteLiteral("\r\n    </div>\r\n");
>>>>>>> parent of 812cdf2 (Merge pull request #8 from alexpopescu021/Alina)
#nullable restore
#line 63 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\Index.cshtml"

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
