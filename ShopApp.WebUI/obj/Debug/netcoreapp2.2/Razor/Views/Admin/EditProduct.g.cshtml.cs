#pragma checksum "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d428692ca953ee0afffb9f41d1cb22a3f48f2db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditProduct), @"mvc.1.0.view", @"/Views/Admin/EditProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/EditProduct.cshtml", typeof(AspNetCore.Views_Admin_EditProduct))]
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
#line 1 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.Entities;

#line default
#line hidden
#line 2 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Models;

#line default
#line hidden
#line 3 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\_ViewImports.cshtml"
using ShopApp.WebUI.Extensions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d428692ca953ee0afffb9f41d1cb22a3f48f2db", @"/Views/Admin/EditProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c568fe72079a0164016bc682254953f086523ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/ckeditor/ckeditor.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-2 col-form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editor"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
  
    ViewData["Title"] = "EditProduct";
    var counter = 0;

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(107, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                BeginContext(294, 4, true);
                WriteLiteral("    ");
                EndContext();
                BeginContext(298, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db8031", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(347, 68, true);
                WriteLiteral("\r\n    <script>\r\n        CKEDITOR.replace(\"editor\");\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(418, 35, true);
            WriteLiteral("\r\n<h1>Edit Product</h1>\r\n<hr />\r\n\r\n");
            EndContext();
            BeginContext(453, 3286, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db9523", async() => {
                BeginContext(544, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(550, 60, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db9908", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 19 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(610, 101, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n\r\n            <input type=\"hidden\" name=\"Id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 711, "\"", 728, 1);
#line 23 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 719, Model.Id, 719, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(729, 63, true);
                WriteLiteral(" />\r\n            <div class=\"form-group row\">\r\n                ");
                EndContext();
                BeginContext(792, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db12301", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 25 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(854, 63, true);
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
                EndContext();
                BeginContext(917, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db14072", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 27 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 27 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
                                     WriteLiteral(Model.Name);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(982, 104, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
                EndContext();
                BeginContext(1086, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db16539", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 31 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ImageUrl);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1152, 99, true);
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <input type=\"hidden\" name=\"ImageUrl\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1251, "\"", 1274, 1);
#line 33 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 1259, Model.ImageUrl, 1259, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1275, 25, true);
                WriteLiteral(" />\r\n                    ");
                EndContext();
                BeginContext(1300, 46, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db18815", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1310, "~/img/", 1310, 6, true);
#line 34 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
AddHtmlAttributeValue("", 1316, Model.ImageUrl, 1316, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1346, 168, true);
                WriteLiteral("\r\n                    <input type=\"file\" name=\"file\" value=\"\" />\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
                EndContext();
                BeginContext(1514, 69, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db20761", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 39 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1583, 63, true);
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
                EndContext();
                BeginContext(1646, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db22541", async() => {
                    BeginContext(1711, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                    BeginContext(1714, 17, false);
#line 42 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
Write(Model.Description);

#line default
#line hidden
                    EndContext();
                    BeginContext(1731, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#line 41 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Description);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1744, 104, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group row\">\r\n                ");
                EndContext();
                BeginContext(1848, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db24977", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 47 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Price);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1911, 63, true);
                WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
                EndContext();
                BeginContext(1974, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d428692ca953ee0afffb9f41d1cb22a3f48f2db26751", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 49 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Price);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#line 49 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
                                      WriteLiteral(Model.Price);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2041, 28, true);
                WriteLiteral("\r\n                </div>\r\n\r\n");
                EndContext();
                BeginContext(2306, 288, true);
                WriteLiteral(@"            </div>
            <div class=""form-group row"">
                <div class=""col-md-10"">
                    <button type=""submit"" class=""btn btn-primary"">Save Product</button>
                </div>
            </div>

        </div>

        <div class=""col-md-4"">
");
                EndContext();
#line 66 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
             foreach (var item in (List<Category>)ViewBag.Categories)
            {
                var isChecked = "";

                if (Model.SelectedCategories.Any(i => i.Id == item.Id))
                {
                    isChecked = "checked";


#line default
#line hidden
                BeginContext(2857, 40, true);
                WriteLiteral("                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2897, "\"", 2935, 3);
                WriteAttributeValue("", 2904, "SelectedCategories[", 2904, 19, true);
#line 74 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 2923, counter, 2923, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 2931, "].Id", 2931, 4, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2936, "\"", 2952, 1);
#line 74 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 2944, item.Id, 2944, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2953, 45, true);
                WriteLiteral(" />\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 2998, "\"", 3038, 3);
                WriteAttributeValue("", 3005, "SelectedCategories[", 3005, 19, true);
#line 75 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 3024, counter, 3024, 8, false);

#line default
#line hidden
                WriteAttributeValue("", 3032, "].Name", 3032, 6, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3039, "\"", 3057, 1);
#line 75 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 3047, item.Name, 3047, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3058, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
#line 76 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"

                    counter++;
                }
                else
                {
                    isChecked = "";
                }


#line default
#line hidden
                BeginContext(3215, 151, true);
                WriteLiteral("                <div class=\"custom-control custom-checkbox\">\r\n                    <input type=\"checkbox\"\r\n                           name=\"categoryIds\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                           value=\"", 3366, "\"", 3410, 1);
#line 87 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 3402, item.Id, 3402, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3411, 57, true);
                WriteLiteral("\r\n                           class=\"custom-control-input\"");
                EndContext();
                BeginWriteAttribute("id", "\r\n                           id=\"", 3468, "\"", 3519, 2);
                WriteAttributeValue("", 3501, "category", 3501, 8, true);
#line 89 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 3509, item.Id, 3509, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3520, 29, true);
                WriteLiteral("\r\n                           ");
                EndContext();
                BeginContext(3550, 9, false);
#line 90 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
                      Write(isChecked);

#line default
#line hidden
                EndContext();
                BeginContext(3559, 60, true);
                WriteLiteral(">\r\n\r\n                    <label class=\"custom-control-label\"");
                EndContext();
                BeginWriteAttribute("for", " for=\"", 3619, "\"", 3643, 2);
                WriteAttributeValue("", 3625, "category", 3625, 8, true);
#line 92 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
WriteAttributeValue("", 3633, item.Id, 3633, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3644, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(3646, 9, false);
#line 92 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
                                                                            Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(3655, 34, true);
                WriteLiteral("</label>\r\n                </div>\r\n");
                EndContext();
#line 94 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Admin\EditProduct.cshtml"
            }

#line default
#line hidden
                BeginContext(3704, 28, true);
                WriteLiteral("        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
