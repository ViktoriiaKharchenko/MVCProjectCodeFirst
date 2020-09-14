#pragma checksum "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "980e863ab17b8c65642f6c779ded4c8b9fd412c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"980e863ab17b8c65642f6c779ded4c8b9fd412c8", @"/Views/Clients/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ff6aa91c53c7b07c98a15e550099080804ceac", @"/Views/_ViewImports.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InsuranceDatabase.Clients>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Клієнти</h1>
<link rel=""stylesheet"" type=""text/css"" href=""~/css/style3.css"">
<meta name=""viewport"" content=""width=device-width, initial-scale=1"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
<script src=""~/js/script3.js""></script>
<meta charset=""utf-8""></meta>
<p>
    <a asp-action=""Create"">Додати клієнта</a>
</p>

<form asp-controller=""Clients"" asp-action=""Index"">
    <section id=""search"">
        <div id=""center"">
            <div id=""menu"">
                <div id=""button1"">
                    <span>Пошук по імені</span>
                </div>

                <div id=""button4"">
                    <span>Клієнти брокера</span>
                </div>
            </div>

            <div id=""line""></div>
            <div id=""number"" type=""submit"">
                <input id=""num"" name=""searchString"" placeholder=""Ім'я клієнта"">
                <button id=""button"" type=""submit"">
                    <span>Пошук</span>
                ");
            WriteLiteral("</button>\r\n            </div>\r\n\r\n            <div id=\"category\">\r\n                <select id=\"categories\" name=\"broker\">\r\n                    <option");
            BeginWriteAttribute("value", " value=\"", 1263, "\"", 1271, 0);
            EndWriteAttribute();
            WriteLiteral(">Клієнти брокера : </option>\r\n");
#nullable restore
#line 41 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
                     foreach (Brokers b in ViewBag.Brokers)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1417, "\"", 1430, 1);
#nullable restore
#line 43 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
WriteAttributeValue("", 1425, b.Id, 1425, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 43 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
                                         Write(b.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 44 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </select>\r\n                <button id=\"button\" type=\"submit\">\r\n                    <span>Пошук</span>\r\n                </button>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</form>\r\n<p>\r\n    <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-categories", " asp-route-categories=\"", 1714, "\"", 1756, 1);
#nullable restore
#line 54 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
WriteAttributeValue("", 1737, ViewBag.Categories, 1737, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Переглянути клієнтів, що підписали договори в усіх категоріях</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr class=\"table-primary\">\r\n            <th>\r\n                ");
#nullable restore
#line 60 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 63 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 69 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"table-light\">\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n                    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2531, "\"", 2554, 1);
#nullable restore
#line 80 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
WriteAttributeValue("", 2546, item.Id, 2546, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Редагувати</a> |\r\n                    <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2617, "\"", 2640, 1);
#nullable restore
#line 81 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
WriteAttributeValue("", 2632, item.Id, 2632, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Деталі</a> |\r\n                    <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2698, "\"", 2721, 1);
#nullable restore
#line 82 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
WriteAttributeValue("", 2713, item.Id, 2713, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Видалити</a>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 85 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Clients\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InsuranceDatabase.Clients>> Html { get; private set; }
    }
}
#pragma warning restore 1591
