#pragma checksum "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Types\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "632ac870a8a0ab4b71b2b398eeb6a51e52508e50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Types_Edit), @"mvc.1.0.view", @"/Views/Types/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"632ac870a8a0ab4b71b2b398eeb6a51e52508e50", @"/Views/Types/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ff6aa91c53c7b07c98a15e550099080804ceac", @"/Views/_ViewImports.cshtml")]
    public class Views_Types_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InsuranceDatabase.Types>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Types\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <hr />
<h4>Редагувати вид страхування</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Type"" class=""control-label""></label>
                <input asp-for=""Type"" class=""form-control"" />
                <span asp-validation-for=""Type"" class=""text-danger""></span>
            </div>

            <div class=""form-group"">
                <label asp-for=""Info"" class=""control-label""></label>
                <input asp-for=""Info"" class=""form-control"" />
                <span asp-validation-for=""Info"" class=""text-danger""></span>
            </div>
            <input type=""hidden""");
            BeginWriteAttribute("value", " value=\"", 914, "\"", 941, 1);
#nullable restore
#line 26 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Types\Edit.cshtml"
WriteAttributeValue("", 922, ViewBag.CategoryId, 922, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"CategoryId\" />\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Зберегти\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1176, "\"", 1210, 1);
#nullable restore
#line 35 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Types\Edit.cshtml"
WriteAttributeValue("", 1191, ViewBag.CategoryId, 1191, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("asp-route-category", " asp-route-category=\"", 1211, "\"", 1253, 1);
#nullable restore
#line 35 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Types\Edit.cshtml"
WriteAttributeValue("", 1232, ViewBag.CategoryName, 1232, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Повернутись</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 39 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Types\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InsuranceDatabase.Types> Html { get; private set; }
    }
}
#pragma warning restore 1591
