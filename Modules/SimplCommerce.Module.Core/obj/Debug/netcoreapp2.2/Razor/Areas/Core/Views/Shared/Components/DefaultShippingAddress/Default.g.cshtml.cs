#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad1875d33c2ced1530f4f9cd27174e82659963f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Core_Views_Shared_Components_DefaultShippingAddress_Default), @"mvc.1.0.view", @"/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml", typeof(AspNetCore.Areas_Core_Views_Shared_Components_DefaultShippingAddress_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad1875d33c2ced1530f4f9cd27174e82659963f1", @"/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f9af2dbfb59a463c9fdb28e6eb5cce06455bad", @"/Areas/Core/Views/_ViewImports.cshtml")]
    public class Areas_Core_Views_Shared_Components_DefaultShippingAddress_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage.DefaultAddressViewComponentVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/user/address"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(92, 7, true);
            WriteLiteral("\n<div>\n");
            EndContext();
#line 4 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
     if (Model.Address != null)
    {

#line default
#line hidden
            BeginContext(137, 32, true);
            WriteLiteral("        <p>\n            <strong>");
            EndContext();
            BeginContext(170, 25, false);
#line 7 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
               Write(Model.Address.ContactName);

#line default
#line hidden
            EndContext();
            BeginContext(195, 28, true);
            WriteLiteral(" </strong><br/>\n            ");
            EndContext();
            BeginContext(224, 26, false);
#line 8 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
       Write(Model.Address.AddressLine1);

#line default
#line hidden
            EndContext();
            BeginContext(250, 19, true);
            WriteLiteral(" <br/>\n            ");
            EndContext();
            BeginContext(270, 26, false);
#line 9 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
       Write(Model.Address.DistrictName);

#line default
#line hidden
            EndContext();
            BeginContext(296, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(299, 33, false);
#line 9 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
                                    Write(Model.Address.StateOrProvinceName);

#line default
#line hidden
            EndContext();
            BeginContext(332, 19, true);
            WriteLiteral(" <br/>\n            ");
            EndContext();
            BeginContext(352, 19, false);
#line 10 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
       Write(Model.Address.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(371, 14, true);
            WriteLiteral("\n        </p>\n");
            EndContext();
#line 12 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(406, 24, true);
            WriteLiteral("        <p>\n            ");
            EndContext();
            BeginContext(431, 47, false);
#line 16 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
       Write(Localizer["You don't have any default address"]);

#line default
#line hidden
            EndContext();
            BeginContext(478, 14, true);
            WriteLiteral("\n        </p>\n");
            EndContext();
#line 18 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
    }

#line default
#line hidden
            BeginContext(498, 35, true);
            WriteLiteral("    <p class=\"text-right\">\n        ");
            EndContext();
            BeginContext(533, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad1875d33c2ced1530f4f9cd27174e82659963f18955", async() => {
                BeginContext(559, 27, false);
#line 20 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Shared/Components/DefaultShippingAddress/Default.cshtml"
                            Write(Localizer["Manage address"]);

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
            BeginContext(590, 17, true);
            WriteLiteral("\n    </p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Core.Areas.Core.ViewModels.Manage.DefaultAddressViewComponentVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
