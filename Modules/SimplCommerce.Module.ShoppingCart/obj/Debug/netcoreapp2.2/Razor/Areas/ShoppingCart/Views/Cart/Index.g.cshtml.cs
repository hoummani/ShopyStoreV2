#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a048c5a0b1b932889aecfd21de7a87e6cdf4a1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ShoppingCart_Views_Cart_Index), @"mvc.1.0.view", @"/Areas/ShoppingCart/Views/Cart/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ShoppingCart/Views/Cart/Index.cshtml", typeof(AspNetCore.Areas_ShoppingCart_Views_Cart_Index))]
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
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a048c5a0b1b932889aecfd21de7a87e6cdf4a1c", @"/Areas/ShoppingCart/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/ShoppingCart/Views/_ViewImports.cshtml")]
    public class Areas_ShoppingCart_Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/checkout/shipping"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("ng-class", new global::Microsoft.AspNetCore.Html.HtmlString("{disabled: !vm.cart.isValid}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/shoppingcart/shoppingcart-list.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/shoppingcart/shoppingcart-service.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
  
    ViewData["Title"] = "Shopping Cart";

#line default
#line hidden
            BeginContext(46, 268, true);
            WriteLiteral(@"
<div class=""row cart-list"" ng-app=""simpl.shoppingCart"" ng-controller=""shoppingCartListCtrl as vm"" ng-cloak>
    <div class=""col-md-8"">
        <table class=""table table-striped cart-items"">
            <thead>
                <tr>
                    <th colspan=""2"">");
            EndContext();
            BeginContext(315, 20, false);
#line 10 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                               Write(Localizer["Product"]);

#line default
#line hidden
            EndContext();
            BeginContext(335, 49, true);
            WriteLiteral("</th>\n                    <th class=\"text-right\">");
            EndContext();
            BeginContext(385, 18, false);
#line 11 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                                      Write(Localizer["Price"]);

#line default
#line hidden
            EndContext();
            BeginContext(403, 50, true);
            WriteLiteral("</th>\n                    <th class=\"text-center\">");
            EndContext();
            BeginContext(454, 21, false);
#line 12 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                                       Write(Localizer["Quantity"]);

#line default
#line hidden
            EndContext();
            BeginContext(475, 1945, true);
            WriteLiteral(@"</th>
                    <th></th>
                </tr>
            </thead>
            <tbody>
                <tr ng-if=""vm.cart.items.length"" ng-repeat=""cartItem in vm.cart.items"">
                    <td class=""product-image""><img ng-src=""{{cartItem.productImage}}"" /></td>
                    <td>
                        <h4>{{cartItem.productName}}</h4>
                        <ul class=""list-unstyled"">
                            <li ng-repeat=""opt in cartItem.variationOptions"">
                                <span>{{opt.optionName}}:</span> {{opt.value}}
                            </li>
                        </ul>
                        <span ng-if=""!cartItem.isProductAvailabeToOrder"" class=""badge badge-pill badge-danger"">Not availabe any more</span>
                        <span ng-if=""cartItem.productStockTrackingIsEnabled && cartItem.productStockQuantity < cartItem.quantity"" class=""badge badge-pill badge-danger"">Not enough stock. Available {{cartItem.productStockQuantity}}</span>
           ");
            WriteLiteral(@"         </td>
                    <td class=""text-right"">{{cartItem.productPriceString}}</td>
                    <td class=""text-center"">
                        <button type=""button"" class=""quantity-button"" ng-click=""vm.decreaseQuantity(cartItem)"" name=""subtract"" value=""-"">-</button>
                        <input type=""text"" class=""quantity-field"" ng-model=""cartItem.quantity"" readonly=""readonly"" />
                        <button type=""button"" class=""quantity-button"" ng-click=""vm.increaseQuantity(cartItem)"" name=""subtract"" value=""+"">+</button>
                    </td>
                    <td class=""text-right""><button class=""btn btn-link"" ng-click=""vm.removeShoppingCartItem(cartItem)""><span class=""fa fa-remove"" aria-hidden=""true""></span></button></td>
                </tr>
                <tr ng-if=""!vm.cart.items.length"">
                    <td colspan=""5"" class=""text-center"">
                        ");
            EndContext();
            BeginContext(2421, 45, false);
#line 39 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                   Write(Localizer["There are no items in this cart."]);

#line default
#line hidden
            EndContext();
            BeginContext(2466, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2467, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a048c5a0b1b932889aecfd21de7a87e6cdf4a1c10954", async() => {
                BeginContext(2481, 27, false);
#line 39 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                                                                               Write(Localizer["Go to shopping"]);

#line default
#line hidden
                EndContext();
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
            BeginContext(2512, 141, true);
            WriteLiteral("\n                    </td>\n                </tr>\n            </tbody>\n        </table>\n        <div class=\"order-note-form\">\n            <h4>");
            EndContext();
            BeginContext(2654, 23, false);
#line 45 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
           Write(Localizer["Order note"]);

#line default
#line hidden
            EndContext();
            BeginContext(2677, 18, true);
            WriteLiteral("</h4>\n            ");
            EndContext();
            BeginContext(2695, 435, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a048c5a0b1b932889aecfd21de7a87e6cdf4a1c13082", async() => {
                BeginContext(2701, 422, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <textarea rows=""3"" class=""form-control"" name=""orderNote"" ng-model=""vm.cart.orderNote"" placeholder=""Enter order note""></textarea>
                </div>
                <div class=""form-group"">
                    <button type=""submit"" class=""btn btn-default pull-right"" ng-click=""vm.saveOrderNote()"">Save order note</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3130, 135, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"col-md-4\">\n        <div class=\"order-summary\" ng-if=\"vm.cart.items.length\">\n            <h4>");
            EndContext();
            BeginContext(3266, 26, false);
#line 58 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
           Write(Localizer["Order summary"]);

#line default
#line hidden
            EndContext();
            BeginContext(3292, 85, true);
            WriteLiteral("</h4>\n            <table class=\"table\">\n                <tr>\n                    <td>");
            EndContext();
            BeginContext(3378, 21, false);
#line 61 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                   Write(Localizer["Subtotal"]);

#line default
#line hidden
            EndContext();
            BeginContext(3399, 129, true);
            WriteLiteral("</td>\n                    <td>{{vm.cart.subTotalString}}</td>\n                </tr>\n                <tr>\n                    <td>");
            EndContext();
            BeginContext(3529, 21, false);
#line 65 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                   Write(Localizer["Discount"]);

#line default
#line hidden
            EndContext();
            BeginContext(3550, 152, true);
            WriteLiteral(" {{vm.cart.couponCode}}</td>\n                    <td>{{vm.cart.discountString}}</td>\n                </tr>\n                <tr>\n                    <td>");
            EndContext();
            BeginContext(3703, 24, false);
#line 69 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                   Write(Localizer["Order Total"]);

#line default
#line hidden
            EndContext();
            BeginContext(3727, 158, true);
            WriteLiteral("</td>\n                    <td><strong>{{vm.cart.orderTotalString}}</strong></td>\n                </tr>\n            </table>\n            <p class=\"text-right\">");
            EndContext();
            BeginContext(3885, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a048c5a0b1b932889aecfd21de7a87e6cdf4a1c17309", async() => {
                BeginContext(3980, 32, false);
#line 73 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                                                                                                                           Write(Localizer["Process to Checkout"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4016, 99, true);
            WriteLiteral("</p>\n        </div>\n        <div class=\"coupon-form\" ng-if=\"vm.cart.items.length\">\n            <h4>");
            EndContext();
            BeginContext(4116, 24, false);
#line 76 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
           Write(Localizer["Coupon code"]);

#line default
#line hidden
            EndContext();
            BeginContext(4140, 18, true);
            WriteLiteral("</h4>\n            ");
            EndContext();
            BeginContext(4158, 504, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a048c5a0b1b932889aecfd21de7a87e6cdf4a1c19607", async() => {
                BeginContext(4184, 407, true);
                WriteLiteral(@"
                <div class=""form-group"">
                    <label>{{vm.cart.couponValidationErrorMessage}}</label>
                </div>
                <div class=""form-group"">
                    <input type=""text"" class=""form-control"" name=""couponCode"" ng-model=""vm.couponCode"" placeholder=""Enter coupon"">
                    <button type=""submit"" class=""btn btn-default"" ng-click=""vm.applyCoupon()"">");
                EndContext();
                BeginContext(4592, 18, false);
#line 83 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
                                                                                         Write(Localizer["Apply"]);

#line default
#line hidden
                EndContext();
                BeginContext(4610, 45, true);
                WriteLiteral("</button>\n                </div>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4662, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("head", async() => {
                BeginContext(4711, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(4716, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a048c5a0b1b932889aecfd21de7a87e6cdf4a1c22300", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper = CreateTagHelper<global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper>();
                __tagHelperExecutionContext.Add(__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper);
#line 91 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("simpl-append-version", __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4811, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(4816, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a048c5a0b1b932889aecfd21de7a87e6cdf4a1c24408", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper = CreateTagHelper<global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper>();
                __tagHelperExecutionContext.Add(__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper);
#line 92 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/Index.cshtml"
__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("simpl-append-version", __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4914, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
