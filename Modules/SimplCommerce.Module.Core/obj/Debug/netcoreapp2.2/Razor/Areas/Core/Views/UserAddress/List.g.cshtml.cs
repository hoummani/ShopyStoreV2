#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44cfdaf06a55e8c7975ae59d387d125e99632cf1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Core_Views_UserAddress_List), @"mvc.1.0.view", @"/Areas/Core/Views/UserAddress/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Core/Views/UserAddress/List.cshtml", typeof(AspNetCore.Areas_Core_Views_UserAddress_List))]
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
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using SimplCommerce.Module.Core;

#line default
#line hidden
#line 2 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using SimplCommerce.Module.Core.Models;

#line default
#line hidden
#line 3 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Account;

#line default
#line hidden
#line 4 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage;

#line default
#line hidden
#line 5 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 6 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44cfdaf06a55e8c7975ae59d387d125e99632cf1", @"/Areas/Core/Views/UserAddress/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f9af2dbfb59a463c9fdb28e6eb5cce06455bad", @"/Areas/Core/Views/_ViewImports.cshtml")]
    public class Areas_Core_Views_UserAddress_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimplCommerce.Module.Core.Areas.Core.ViewModels.UserAddressListItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AccountMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Core", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UserAddress", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SetAsDefault", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/user/address/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
  
    ViewData["Title"] = "Address book";

#line default
#line hidden
            BeginContext(133, 54, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-3\">\n        ");
            EndContext();
            BeginContext(187, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "44cfdaf06a55e8c7975ae59d387d125e99632cf18092", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(218, 51, true);
            WriteLiteral("\n    </div>\n    <div class=\"col-md-9\">\n        <h2>");
            EndContext();
            BeginContext(270, 25, false);
#line 11 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
       Write(Localizer["Address Book"]);

#line default
#line hidden
            EndContext();
            BeginContext(295, 21, true);
            WriteLiteral("</h2>\n        <hr />\n");
            EndContext();
#line 13 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
         foreach (var address in Model)
        {

#line default
#line hidden
            BeginContext(366, 42, true);
            WriteLiteral("            <div>\n                <strong>");
            EndContext();
            BeginContext(409, 19, false);
#line 16 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                   Write(address.ContactName);

#line default
#line hidden
            EndContext();
            BeginContext(428, 33, true);
            WriteLiteral(" </strong><br />\n                ");
            EndContext();
            BeginContext(462, 20, false);
#line 17 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
           Write(address.AddressLine1);

#line default
#line hidden
            EndContext();
            BeginContext(482, 8, true);
            WriteLiteral(" <br />\n");
            EndContext();
#line 18 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                 if(address.DisplayDistrict){
                    

#line default
#line hidden
            BeginContext(563, 20, false);
#line 19 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                     Write(address.DistrictName);

#line default
#line hidden
            EndContext();
            BeginContext(583, 1, true);
            WriteLiteral(",");
            EndContext();
#line 19 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                                                       
                }

#line default
#line hidden
            BeginContext(610, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(627, 27, false);
#line 21 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
           Write(address.StateOrProvinceName);

#line default
#line hidden
            EndContext();
            BeginContext(654, 31, true);
            WriteLiteral(" <br />\n                Phone: ");
            EndContext();
            BeginContext(686, 13, false);
#line 22 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                  Write(address.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(699, 38, true);
            WriteLiteral("\n            </div>\n            <div>\n");
            EndContext();
#line 25 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                 if (address.IsDefaultShippingAddress)
                {

#line default
#line hidden
            BeginContext(810, 54, true);
            WriteLiteral("                    <span class=\"label label-primary\">");
            EndContext();
            BeginContext(865, 37, false);
#line 27 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                                                 Write(Localizer["Default shipping address"]);

#line default
#line hidden
            EndContext();
            BeginContext(902, 8, true);
            WriteLiteral("</span>\n");
            EndContext();
#line 28 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(967, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(987, 322, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44cfdaf06a55e8c7975ae59d387d125e99632cf114178", async() => {
                BeginContext(1140, 87, true);
                WriteLiteral("\n                        <button type=\"submit\" class=\"btn btn-link\" style=\"padding: 0\">");
                EndContext();
                BeginContext(1228, 44, false);
#line 32 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                                                                                 Write(Localizer["Set as default shipping address"]);

#line default
#line hidden
                EndContext();
                BeginContext(1272, 30, true);
                WriteLiteral("</button>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 31 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                                                                                                                                         WriteLiteral(address.UserAddressId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1309, 38, true);
            WriteLiteral("\n                    <span> | </span>\n");
            EndContext();
#line 35 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                }

#line default
#line hidden
            BeginContext(1365, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1381, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44cfdaf06a55e8c7975ae59d387d125e99632cf118594", async() => {
                BeginContext(1435, 17, false);
#line 36 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                                                                Write(Localizer["Edit"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1390, "~/user/address/edit/", 1390, 20, true);
#line 36 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
AddHtmlAttributeValue("", 1410, address.UserAddressId, 1410, 22, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1456, 33, true);
            WriteLiteral("<span> | </span>\n                ");
            EndContext();
            BeginContext(1489, 283, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44cfdaf06a55e8c7975ae59d387d125e99632cf120641", async() => {
                BeginContext(1636, 83, true);
                WriteLiteral("\n                    <button type=\"submit\" class=\"btn btn-link\" style=\"padding: 0\">");
                EndContext();
                BeginContext(1720, 19, false);
#line 38 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                                                                             Write(Localizer["Delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(1739, 26, true);
                WriteLiteral("</button>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 37 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                                                                                                                               WriteLiteral(address.UserAddressId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1772, 39, true);
            WriteLiteral("\n            </div>\n            <hr />\n");
            EndContext();
#line 42 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
        }

#line default
#line hidden
            BeginContext(1821, 33, true);
            WriteLiteral("\n        <div class=\"text-right\">");
            EndContext();
            BeginContext(1854, 85, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44cfdaf06a55e8c7975ae59d387d125e99632cf125024", async() => {
                BeginContext(1911, 24, false);
#line 44 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/UserAddress/List.cshtml"
                                                                                   Write(Localizer["Add Address"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1939, 25, true);
            WriteLiteral("</div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimplCommerce.Module.Core.Areas.Core.ViewModels.UserAddressListItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
