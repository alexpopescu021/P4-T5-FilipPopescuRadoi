#pragma checksum "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Payments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42f05c949c8dcb8248176202df2056a915dd34a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payments_Details), @"mvc.1.0.view", @"/Views/Payments/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42f05c949c8dcb8248176202df2056a915dd34a3", @"/Views/Payments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27784ff01484f2c7b020357b84fbefa54860bf9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Payments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BankingProject.ApplicationLogic.Model.Transaction>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Payments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Transaction details</h2>\r\n\r\n<div style=\"padding-left: 25px;\">\r\n    <div>\r\n        <strong>\r\n            Amount:\r\n        </strong>\r\n        ");
#nullable restore
#line 13 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Payments\Details.cshtml"
   Write(Model.Amount.ToString("N"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <strong>\r\n            Date:\r\n        </strong>\r\n        ");
#nullable restore
#line 19 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Payments\Details.cshtml"
   Write(Model.Time.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        <strong>\r\n            External IBAN:\r\n        </strong>\r\n        ");
#nullable restore
#line 26 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Payments\Details.cshtml"
   Write(Model.ExternalIBAN);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n    <div>\r\n        <strong>\r\n            External Name:\r\n        </strong>\r\n        ");
#nullable restore
#line 33 "C:\Users\Alina\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Payments\Details.cshtml"
   Write(Model.ExternalName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BankingProject.ApplicationLogic.Model.Transaction> Html { get; private set; }
    }
}
#pragma warning restore 1591
