#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eede8cdb9bd0c2bb275fb1e680dbe6b416f35e90"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cms_Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml", typeof(AspNetCore.Areas_Cms_Views_Shared_Components_Menu_Default))]
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
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eede8cdb9bd0c2bb275fb1e680dbe6b416f35e90", @"/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e487af9f599b2cd461681599ad34205d5bca37", @"/Areas/Cms/Views/_ViewImports.cshtml")]
    public class Areas_Cms_Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.MenuItemVm>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(77, 28, true);
            WriteLiteral("\n<ul class=\"list-unstyled\">\n");
            EndContext();
#line 4 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(144, 27, true);
            WriteLiteral("        <li>\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 171, "\"", 188, 1);
#line 7 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
WriteAttributeValue("", 178, item.Link, 178, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(189, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(191, 9, false);
#line 7 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
                            Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(200, 5, true);
            WriteLiteral("</a>\n");
            EndContext();
#line 8 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
              if (item.ChildItems.Any())
             {

#line default
#line hidden
            BeginContext(261, 21, true);
            WriteLiteral("                <ul>\n");
            EndContext();
#line 11 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
                     foreach (var childItem in item.ChildItems)
                    {

#line default
#line hidden
            BeginContext(368, 30, true);
            WriteLiteral("                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 398, "\"", 420, 1);
#line 13 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
WriteAttributeValue("", 405, childItem.Link, 405, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(421, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(423, 14, false);
#line 13 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
                                                 Write(childItem.Name);

#line default
#line hidden
            EndContext();
            BeginContext(437, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 14 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(469, 22, true);
            WriteLiteral("                </ul>\n");
            EndContext();
#line 16 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
             }

#line default
#line hidden
            BeginContext(506, 14, true);
            WriteLiteral("        </li>\n");
            EndContext();
#line 18 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Shared/Components/Menu/Default.cshtml"
    }

#line default
#line hidden
            BeginContext(526, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SimplCommerce.Module.Cms.Areas.Cms.ViewModels.MenuItemVm>> Html { get; private set; }
    }
}
#pragma warning restore 1591
