#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1602bd57c98f83bcb3c68c6c739331197f624734"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_WishList_Views_WishList_PublicList), @"mvc.1.0.view", @"/Areas/WishList/Views/WishList/PublicList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/WishList/Views/WishList/PublicList.cshtml", typeof(AspNetCore.Areas_WishList_Views_WishList_PublicList))]
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
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
using cloudscribe.Web.Pagination;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1602bd57c98f83bcb3c68c6c739331197f624734", @"/Areas/WishList/Views/WishList/PublicList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b2c487d7b43dfd757769bef8d011e5e40d81380", @"/Areas/WishList/Views/_ViewImports.cshtml")]
    public class Areas_WishList_Views_WishList_PublicList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.WishList.Areas.WishList.ViewModels.WishListVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/modules/wishlist/public-list.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pagenumber-param", "pageNumber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "WishList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PublicList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-current-class", "page-item active", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-other-class", "page-item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-li-non-active-class", "page-item disabled", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-current-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("cs-pager-link-other-class", "page-link", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::cloudscribe.Web.Pagination.PagerTagHelper __cloudscribe_Web_Pagination_PagerTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
  
    ViewData["Title"] = Localizer["Wish List"];

#line default
#line hidden
            BeginContext(161, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("head", async() => {
                BeginContext(177, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(182, 95, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1602bd57c98f83bcb3c68c6c739331197f6247348098", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper = CreateTagHelper<global::SimplCommerce.Module.Core.Extensions.TagHelpers.AppendVersionTagHelper>();
                __tagHelperExecutionContext.Add(__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper);
#line 9 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
__SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion = true;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("simpl-append-version", __SimplCommerce_Module_Core_Extensions_TagHelpers_AppendVersionTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(277, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(280, 68, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"wishlist col-md-12\">\n        <h2>");
            EndContext();
            BeginContext(349, 22, false);
#line 14 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
       Write(Localizer["Wish List"]);

#line default
#line hidden
            EndContext();
            BeginContext(371, 21, true);
            WriteLiteral("</h2>\n        <hr />\n");
            EndContext();
#line 16 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
         if (Model.Items.TotalItems > 0)
        {
            foreach (var item in Model.Items.Data)
            {

#line default
#line hidden
            BeginContext(508, 110, true);
            WriteLiteral("                <div class=\"row item\">\n                    <div class=\"col-md-4\">\n                        <img");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 618, "\"", 641, 1);
#line 22 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
WriteAttributeValue("", 624, item.ProductName, 624, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(642, 18, true);
            WriteLiteral(" class=\"img-fluid\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 660, "\"", 684, 1);
#line 22 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
WriteAttributeValue("", 666, item.ProductImage, 666, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(685, 100, true);
            WriteLiteral(">\n                    </div>\n                    <div class=\"col-md-8\">\n                        <h4>");
            EndContext();
            BeginContext(786, 16, false);
#line 25 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
                       Write(item.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(802, 33, true);
            WriteLiteral("</h4>\n                        <p>");
            EndContext();
            BeginContext(836, 16, false);
#line 26 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(852, 29, true);
            WriteLiteral("</p>\n                        ");
            EndContext();
            BeginContext(881, 519, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1602bd57c98f83bcb3c68c6c739331197f62473413383", async() => {
                BeginContext(887, 32, true);
                WriteLiteral("\n                            <p>");
                EndContext();
                BeginContext(920, 21, false);
#line 28 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
                          Write(Localizer["Quantity"]);

#line default
#line hidden
                EndContext();
                BeginContext(941, 2, true);
                WriteLiteral(": ");
                EndContext();
                BeginContext(944, 13, false);
#line 28 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
                                                  Write(item.Quantity);

#line default
#line hidden
                EndContext();
                BeginContext(957, 67, true);
                WriteLiteral("</p>\n                            <input type=\"hidden\" name=\"itemId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1024, "\"", 1040, 1);
#line 29 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
WriteAttributeValue("", 1032, item.Id, 1032, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1041, 69, true);
                WriteLiteral(" />\n                            <input type=\"hidden\" name=\"productId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1110, "\"", 1133, 1);
#line 30 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
WriteAttributeValue("", 1118, item.ProductId, 1118, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1134, 91, true);
                WriteLiteral(" />\n                            <input type=\"hidden\" name=\"quantity\" class=\"quantity-field\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1225, "\"", 1247, 1);
#line 31 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
WriteAttributeValue("", 1233, item.Quantity, 1233, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1248, 86, true);
                WriteLiteral(" />\n                            <button type=\"button\" class=\"btn btn-lg btn-add-cart\">");
                EndContext();
                BeginContext(1335, 24, false);
#line 32 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
                                                                             Write(Localizer["Add to cart"]);

#line default
#line hidden
                EndContext();
                BeginContext(1359, 34, true);
                WriteLiteral("</button>\n                        ");
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
            BeginContext(1400, 51, true);
            WriteLiteral("\n                    </div>\n                </div>\n");
            EndContext();
#line 36 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
            }

#line default
#line hidden
            BeginContext(1465, 34, true);
            WriteLiteral("            <div>\n                ");
            EndContext();
            BeginContext(1499, 839, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cs-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1602bd57c98f83bcb3c68c6c739331197f62473418482", async() => {
            }
            );
            __cloudscribe_Web_Pagination_PagerTagHelper = CreateTagHelper<global::cloudscribe.Web.Pagination.PagerTagHelper>();
            __tagHelperExecutionContext.Add(__cloudscribe_Web_Pagination_PagerTagHelper);
#line 38 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageSize = Model.Items.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagesize", __cloudscribe_Web_Pagination_PagerTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 39 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.PageNumber = Model.Items.PageNumber;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-pagenumber", __cloudscribe_Web_Pagination_PagerTagHelper.PageNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 40 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
__cloudscribe_Web_Pagination_PagerTagHelper.TotalItems = Model.Items.TotalItems;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("cs-paging-totalitems", __cloudscribe_Web_Pagination_PagerTagHelper.TotalItems, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.PageNumberParam = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __cloudscribe_Web_Pagination_PagerTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __cloudscribe_Web_Pagination_PagerTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__cloudscribe_Web_Pagination_PagerTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "cloudscribe.Web.Pagination.PagerTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
                            WriteLiteral(Model.SharingCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 45 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
                                  WriteLiteral(Model.Items.PageSize);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["pageSize"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageSize", __cloudscribe_Web_Pagination_PagerTagHelper.RouteValues["pageSize"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiCurrentCssClass = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiOtherCssClass = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __cloudscribe_Web_Pagination_PagerTagHelper.LiNonActiveCssClass = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkCurrentCssClass = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __cloudscribe_Web_Pagination_PagerTagHelper.LinkOtherCssClass = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2338, 20, true);
            WriteLiteral("\n            </div>\n");
            EndContext();
#line 52 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2391, 15, true);
            WriteLiteral("            <p>");
            EndContext();
            BeginContext(2407, 59, false);
#line 55 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
          Write(Localizer["There are currently no items in the wish list."]);

#line default
#line hidden
            EndContext();
            BeginContext(2466, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 56 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.WishList/Areas/WishList/Views/WishList/PublicList.cshtml"
        }

#line default
#line hidden
            BeginContext(2481, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.WishList.Areas.WishList.ViewModels.WishListVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
