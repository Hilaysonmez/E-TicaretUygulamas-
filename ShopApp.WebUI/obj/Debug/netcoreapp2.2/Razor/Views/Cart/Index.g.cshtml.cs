#pragma checksum "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c574f9bf89c66a2a203222b62e349ac405fbe72d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cart/Index.cshtml", typeof(AspNetCore.Views_Cart_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c574f9bf89c66a2a203222b62e349ac405fbe72d", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c568fe72079a0164016bc682254953f086523ecc", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CartModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("80"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(59, 162, true);
            WriteLiteral("\r\n<h1>Shopping Cart</h1>\r\n\r\n<div class=\"row mt-5\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"text-left\">\r\n            <h4>Cart Items</h4>\r\n        </div>\r\n");
            EndContext();
#line 13 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
         if (Model.CartItems.Count > 0)
        {

#line default
#line hidden
            BeginContext(273, 416, true);
            WriteLiteral(@"            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th></th>
                        <th>Product Name</th>
                        <th>Price</th>
                        <th>Quantity</th>
                        <th>Total</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 27 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
                     foreach (var item in Model.CartItems)
                    {

#line default
#line hidden
            BeginContext(772, 96, true);
            WriteLiteral("                        <tr>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(868, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c574f9bf89c66a2a203222b62e349ac405fbe72d6376", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 878, "~/img/", 878, 6, true);
#line 31 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
AddHtmlAttributeValue("", 884, item.ImageUrl, 884, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(913, 69, true);
            WriteLiteral("\r\n                            </th>\r\n                            <td>");
            EndContext();
            BeginContext(983, 9, false);
#line 33 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(992, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1032, 24, false);
#line 34 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
                           Write(item.Price.ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1056, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1096, 13, false);
#line 35 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1109, 39, true);
            WriteLiteral("</td>\r\n                            <td>");
            EndContext();
            BeginContext(1150, 42, false);
#line 36 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
                            Write((item.Quantity * item.Price).ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(1193, 75, true);
            WriteLiteral("</td>\r\n                            <td>\r\n\r\n                                ");
            EndContext();
            BeginContext(1268, 427, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c574f9bf89c66a2a203222b62e349ac405fbe72d9749", async() => {
                BeginContext(1338, 75, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1413, "\"", 1436, 1);
#line 40 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1421, item.ProductId, 1421, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1437, 251, true);
                WriteLiteral(" />\r\n                                    <button type=\"submit\" class=\"btn btn-danger btn-sm\">\r\n                                        <i class=\"fa fa-times fa-fw\"></i>\r\n                                    </button>\r\n\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1695, 68, true);
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 48 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1786, 48, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n");
            EndContext();
#line 51 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1870, 105, true);
            WriteLiteral("            <div class=\"alert alert-warning\">\r\n                No Product in Cart! \r\n            </div>\r\n");
            EndContext();
#line 57 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1986, 40, true);
            WriteLiteral("    </div>\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 60 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
         if (Model.CartItems.Count > 0)
        {

#line default
#line hidden
            BeginContext(2078, 255, true);
            WriteLiteral("            <div class=\"text-left\">\r\n                <h4>Cart Summary</h4>\r\n            </div>\r\n            <table class=\"table\">\r\n                <tbody>\r\n                    <tr>\r\n                        <th>Cart Total</th>\r\n                        <td>");
            EndContext();
            BeginContext(2334, 32, false);
#line 69 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
                       Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(2366, 271, true);
            WriteLiteral(@"</td>
                    </tr>

                    <tr>
                        <th>Shipping</th>
                        <td>Free</td>
                    </tr>
                    <tr>
                        <th>Order Total</th>
                        <td>");
            EndContext();
            BeginContext(2638, 32, false);
#line 78 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
                       Write(Model.TotalPrice().ToString("c"));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 463, true);
            WriteLiteral(@"</td>
                    </tr>
                </tbody>
            </table>
            <div class=""text-center"">
                <a href=""/"" class=""btn btn-primary"">
                    <i class=""fa fa-arrow-circle-left fa-fw""></i> Continue Shopping
                </a>
                <a href=""/checkout"" class=""btn btn-primary"">
                    <i class=""fa fa-arrow-circle-right fa-fw""></i> Checkout
                </a>
            </div>
");
            EndContext();
#line 90 "C:\Users\hilay\OneDrive\Masaüstü\ShopApp.WebUI\ShopApp.WebUI\Views\Cart\Index.cshtml"
        }     

#line default
#line hidden
            BeginContext(3149, 22, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CartModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
