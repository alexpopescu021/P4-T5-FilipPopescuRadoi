#pragma checksum "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc388d489edbd5e4fe78c81425f3777c3a72108b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Loans_Index), @"mvc.1.0.view", @"/Views/Loans/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc388d489edbd5e4fe78c81425f3777c3a72108b", @"/Views/Loans/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27784ff01484f2c7b020357b84fbefa54860bf9a", @"/Views/_ViewImports.cshtml")]
    public class Views_Loans_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BankingProject.ApplicationLogic.Model.Loan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Loans</h1>\r\n<br /><br />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.LunarFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 36 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.LunarFee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\alexp\source\repos\P4-T5-FilipPopescuRadoi\BankingProject\Views\Loans\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BankingProject.ApplicationLogic.Model.Loan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
