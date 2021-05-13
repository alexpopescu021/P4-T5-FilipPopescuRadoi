#pragma checksum "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\_TransactionsPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baacd95b137c86252aad5f63828f88915bd6e9d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts__TransactionsPartial), @"mvc.1.0.view", @"/Views/Accounts/_TransactionsPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baacd95b137c86252aad5f63828f88915bd6e9d4", @"/Views/Accounts/_TransactionsPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27784ff01484f2c7b020357b84fbefa54860bf9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts__TransactionsPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BankingProject.ApplicationLogic.Model.Transaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""table-responsive table-shadow"">
    <table class=""table table-striped table-light"">
        <thead class=""table-header"">
            <tr>
                <th>Amount</th>
                <th>Date</th>
                <th class=""d-none d-md-table-cell"">Balance</th>
                <th>Details</th>
                <th class=""d-none d-md-table-cell"">Name</th>
                <th class=""d-none d-md-table-cell"">External Account</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 16 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\_TransactionsPartial.cshtml"
             foreach (var transaction in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\_TransactionsPartial.cshtml"
                   Write(transaction.Amount.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\_TransactionsPartial.cshtml"
                   Write(transaction.Time.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-md-table-cell\">10.30</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\_TransactionsPartial.cshtml"
                   Write(transaction.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-md-table-cell\">");
#nullable restore
#line 23 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\_TransactionsPartial.cshtml"
                                                  Write(transaction.ExternalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"d-none d-md-table-cell\">");
#nullable restore
#line 24 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\_TransactionsPartial.cshtml"
                                                  Write(transaction.ExternalIBAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 26 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Accounts\_TransactionsPartial.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BankingProject.ApplicationLogic.Model.Transaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591
