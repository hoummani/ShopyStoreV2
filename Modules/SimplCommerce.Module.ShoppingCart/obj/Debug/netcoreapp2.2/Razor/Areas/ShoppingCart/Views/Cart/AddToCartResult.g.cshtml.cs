#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f7f2137e6c5e0dbdabfae3b37af46d27bb7d2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_ShoppingCart_Views_Cart_AddToCartResult), @"mvc.1.0.view", @"/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml", typeof(AspNetCore.Areas_ShoppingCart_Views_Cart_AddToCartResult))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f7f2137e6c5e0dbdabfae3b37af46d27bb7d2d", @"/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/ShoppingCart/Views/_ViewImports.cshtml")]
    public class Areas_ShoppingCart_Views_Cart_AddToCartResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels.AddToCartResult>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/cart"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(87, 74, true);
            WriteLiteral("\n<div class=\"modal-header\">\n    <h5 class=\"modal-title\" id=\"myModalLabel\">");
            EndContext();
            BeginContext(162, 52, false);
#line 4 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
                                         Write(Localizer["The product has been added to your cart"]);

#line default
#line hidden
            EndContext();
            BeginContext(214, 236, true);
            WriteLiteral("</h5>\n    <button type=\"button\" class=\"close\" data-dismiss=\"modal\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span></button>\n</div>\n<div class=\"modal-body\">\n    <div class=\"row\">\n        <div class=\"col-md-3\">\n            <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 450, "\"", 474, 1);
#line 10 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
WriteAttributeValue("", 456, Model.ProductName, 456, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(475, 18, true);
            WriteLiteral(" class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 493, "\"", 518, 1);
#line 10 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
WriteAttributeValue("", 499, Model.ProductImage, 499, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(519, 64, true);
            WriteLiteral(">\n        </div>\n        <div class=\"col-md-6\">\n            <h4>");
            EndContext();
            BeginContext(584, 17, false);
#line 13 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
           Write(Model.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(601, 22, true);
            WriteLiteral("</h4>\n            <h6>");
            EndContext();
            BeginContext(624, 19, false);
#line 14 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
           Write(Model.VariationName);

#line default
#line hidden
            EndContext();
            BeginContext(643, 64, true);
            WriteLiteral("</h6>\n        </div>\n        <div class=\"col-md-3\">\n            ");
            EndContext();
            BeginContext(708, 14, false);
#line 17 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
       Write(Model.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(722, 3, true);
            WriteLiteral(" x ");
            EndContext();
            BeginContext(726, 32, false);
#line 17 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
                         Write(Model.ProductPrice.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(758, 92, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"row\">\n        <div class=\"col-md-7\">\n            ");
            EndContext();
            BeginContext(851, 21, false);
#line 22 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
       Write(Localizer["You have"]);

#line default
#line hidden
            EndContext();
            BeginContext(872, 31, true);
            WriteLiteral(" <span class=\"cart-item-count\">");
            EndContext();
            BeginContext(904, 19, false);
#line 22 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
                                                            Write(Model.CartItemCount);

#line default
#line hidden
            EndContext();
            BeginContext(923, 8, true);
            WriteLiteral("</span> ");
            EndContext();
            BeginContext(932, 34, false);
#line 22 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
                                                                                        Write(Localizer["products in your cart"]);

#line default
#line hidden
            EndContext();
            BeginContext(966, 59, true);
            WriteLiteral("\n        </div>\n        <div class=\"col-md-5\">\n            ");
            EndContext();
            BeginContext(1026, 26, false);
#line 25 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
       Write(Localizer["Cart subtotal"]);

#line default
#line hidden
            EndContext();
            BeginContext(1052, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(1055, 30, false);
#line 25 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
                                    Write(Model.CartAmount.ToString("C"));

#line default
#line hidden
            EndContext();
            BeginContext(1085, 130, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n<div class=\"modal-footer\">\n    <button type=\"button\" class=\"btn btn-light\" data-dismiss=\"modal\">");
            EndContext();
            BeginContext(1216, 30, false);
#line 30 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
                                                                Write(Localizer["Continue shopping"]);

#line default
#line hidden
            EndContext();
            BeginContext(1246, 14, true);
            WriteLiteral("</button>\n    ");
            EndContext();
            BeginContext(1260, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99f7f2137e6c5e0dbdabfae3b37af46d27bb7d2d11475", async() => {
                BeginContext(1314, 22, false);
#line 31 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.ShoppingCart/Areas/ShoppingCart/Views/Cart/AddToCartResult.cshtml"
                                                    Write(Localizer["View cart"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1340, 8, true);
            WriteLiteral("\n</div>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.ShoppingCart.Areas.ShoppingCart.ViewModels.AddToCartResult> Html { get; private set; }
    }
}
#pragma warning restore 1591
