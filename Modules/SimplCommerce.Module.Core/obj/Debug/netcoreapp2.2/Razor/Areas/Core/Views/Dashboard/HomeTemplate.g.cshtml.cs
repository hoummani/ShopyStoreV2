#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1f0e801962a4e6ea7b37ed37c56fa743689fbb29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Core_Views_Dashboard_HomeTemplate), @"mvc.1.0.view", @"/Areas/Core/Views/Dashboard/HomeTemplate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Core/Views/Dashboard/HomeTemplate.cshtml", typeof(AspNetCore.Areas_Core_Views_Dashboard_HomeTemplate))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f0e801962a4e6ea7b37ed37c56fa743689fbb29", @"/Areas/Core/Views/Dashboard/HomeTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8f9af2dbfb59a463c9fdb28e6eb5cce06455bad", @"/Areas/Core/Views/_ViewImports.cshtml")]
    public class Areas_Core_Views_Dashboard_HomeTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(24, 5, true);
            WriteLiteral("\n<h1>");
            EndContext();
            BeginContext(30, 22, false);
#line 5 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
Write(Localizer["Dashboard"]);

#line default
#line hidden
            EndContext();
            BeginContext(52, 174, true);
            WriteLiteral("</h1>\n\n<div class=\"row\">\n    <div class=\"col-md-6\">\n        <div class=\"panel panel-default\">\n            <div class=\"panel-heading\">\n                <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(227, 26, false);
#line 11 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
                                   Write(Localizer["Latest orders"]);

#line default
#line hidden
            EndContext();
            BeginContext(253, 180, true);
            WriteLiteral("</h3>\n            </div>\n            <div class=\"panel-body\">\n                <order-widget status=\"0\" num-records=\"5\"></order-widget>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 18 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
     if (User.IsInRole("admin"))
    {

#line default
#line hidden
            BeginContext(472, 149, true);
            WriteLiteral("    <div class=\"col-md-6\">\n        <div class=\"panel panel-default\">\n            <div class=\"panel-heading\">\n                <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(622, 28, false);
#line 23 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
                                   Write(Localizer["Pending reviews"]);

#line default
#line hidden
            EndContext();
            BeginContext(650, 182, true);
            WriteLiteral("</h3>\n            </div>\n            <div class=\"panel-body\">\n                <review-widget status=\"1\" num-records=\"5\"></review-widget>\n            </div>\n        </div>\n    </div>\n");
            EndContext();
#line 30 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
    }

#line default
#line hidden
            BeginContext(838, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 32 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
 if (User.IsInRole("admin"))
{

#line default
#line hidden
            BeginContext(876, 167, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-6\">\n        <div class=\"panel panel-default\">\n            <div class=\"panel-heading\">\n                <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(1044, 35, false);
#line 38 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
                                   Write(Localizer["Pending review replies"]);

#line default
#line hidden
            EndContext();
            BeginContext(1079, 201, true);
            WriteLiteral("</h3>\n            </div>\n            <div class=\"panel-body\">\n                <review-reply-widget status=\"1\" num-records=\"5\"></review-reply-widget>\n            </div>\n        </div>\n    </div>\n</div>\n");
            EndContext();
#line 46 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
}

#line default
#line hidden
#line 47 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
 if (User.IsInRole("admin"))
{

#line default
#line hidden
            BeginContext(1313, 167, true);
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-md-6\">\n        <div class=\"panel panel-default\">\n            <div class=\"panel-heading\">\n                <h3 class=\"panel-title\">");
            EndContext();
            BeginContext(1481, 35, false);
#line 53 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
                                   Write(Localizer["Most searched keywords"]);

#line default
#line hidden
            EndContext();
            BeginContext(1516, 316, true);
            WriteLiteral(@"</h3>
            </div>
            <div class=""panel-body"">
                <most-search-keyword></most-search-keyword>
            </div>
        </div>
    </div>
    <div class=""col-md-6"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <h3 class=""panel-title"">");
            EndContext();
            BeginContext(1833, 33, false);
#line 63 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
                                   Write(Localizer["Most viewed products"]);

#line default
#line hidden
            EndContext();
            BeginContext(1866, 176, true);
            WriteLiteral("</h3>\n            </div>\n            <div class=\"panel-body\">\n                <most-viewed-products></most-viewed-products>\n            </div>\n        </div>\n    </div>\n</div>\n");
            EndContext();
#line 71 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Core/Areas/Core/Views/Dashboard/HomeTemplate.cshtml"
}

#line default
#line hidden
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
