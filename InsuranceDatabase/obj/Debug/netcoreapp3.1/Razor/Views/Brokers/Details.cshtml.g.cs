#pragma checksum "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e705cc68d1cb6339642110782960991900151788"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Brokers_Details), @"mvc.1.0.view", @"/Views/Brokers/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e705cc68d1cb6339642110782960991900151788", @"/Views/Brokers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4ff6aa91c53c7b07c98a15e550099080804ceac", @"/Views/_ViewImports.cshtml")]
    public class Views_Brokers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<InsuranceDatabase.Brokers>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BrokersDocuments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n    <div>\r\n\r\n        <hr />\r\n        <h4>");
#nullable restore
#line 12 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
       Write(ViewBag.BrokerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 16 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 19 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BrokersCategories));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n");
#nullable restore
#line 30 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
             if (ViewBag.Count == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">\r\n\r\n                </dd>\r\n");
#nullable restore
#line 35 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
             foreach (BrokersCategories category in ViewBag.CategoriesList)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dd class=\"col-sm-10\">\r\n                    <text>");
#nullable restore
#line 39 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                     Write(category.Category.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n                </dd>\r\n");
#nullable restore
#line 41 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                if (ViewBag.CategoriesList[ViewBag.Count - 1] != category)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <dt class=\"col-sm-2\">\r\n                    </dt>\r\n");
#nullable restore
#line 45 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                }

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <dt class=\"col-sm-2\">\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e705cc68d1cb63396421107829609919001517888438", async() => {
                WriteLiteral("Переглянути іниших брокерів в цих категоріях ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-brokerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 52 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                                                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brokerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-brokerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["brokerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 56 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                <text>");
#nullable restore
#line 59 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                 Write(ViewBag.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 59 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                              Write(ViewBag.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral(".");
#nullable restore
#line 59 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                                             Write(ViewBag.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n            </dd>\r\n\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 63 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 66 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayFor(model => model.PhoneNum));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 69 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Passport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 72 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Passport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 75 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 78 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n               Договори \r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e705cc68d1cb633964211078296099190015178814233", async() => {
                WriteLiteral("Переглянути документи");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                                                   WriteLiteral(ViewBag.BrokerId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                                                                                        WriteLiteral(ViewBag.BrokerName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["broker"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-broker", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["broker"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </dd>\r\n\r\n        </dl>\r\n    </div>\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e705cc68d1cb633964211078296099190015178817305", async() => {
                WriteLiteral("Редагувати");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "D:\3 курс\Web-технології\Домашки\MVCProjectCodeFirst\InsuranceDatabase\Views\Brokers\Details.cshtml"
                           WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e705cc68d1cb633964211078296099190015178819474", async() => {
                WriteLiteral("Повернутись");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<InsuranceDatabase.Brokers> Html { get; private set; }
    }
}
#pragma warning restore 1591
