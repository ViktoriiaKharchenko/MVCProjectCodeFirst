#pragma checksum "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18dfd53fe0c430eb94b60455323031be55525408"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Delete), @"mvc.1.0.view", @"/Views/Clients/Delete.cshtml")]
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
#line 1 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\_ViewImports.cshtml"
using InsuranceDatabase;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\_ViewImports.cshtml"
using InsuranceDatabase.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18dfd53fe0c430eb94b60455323031be55525408", @"/Views/Clients/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ff6aa91c53c7b07c98a15e550099080804ceac", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InsuranceDatabase.Clients>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <hr />\r\n    <h3>Ви впевнені, що хочете видалити клієнта ");
#nullable restore
#line 8 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
                                           Write(ViewBag.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("?</h3>\r\n<div>\r\n   \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Passport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Passport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Видалити\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Повернутись</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InsuranceDatabase.Clients> Html { get; private set; }
    }
}
#pragma warning restore 1591
