#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Page/PageDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b72acf7a28934555660a49b225f2428af0ed780c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cms_Views_Page_PageDetail), @"mvc.1.0.view", @"/Areas/Cms/Views/Page/PageDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Cms/Views/Page/PageDetail.cshtml", typeof(AspNetCore.Areas_Cms_Views_Page_PageDetail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b72acf7a28934555660a49b225f2428af0ed780c", @"/Areas/Cms/Views/Page/PageDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e487af9f599b2cd461681599ad34205d5bca37", @"/Areas/Cms/Views/_ViewImports.cshtml")]
    public class Areas_Cms_Views_Page_PageDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Cms.Models.Page>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Page/PageDetail.cshtml"
  
    ViewBag.Title = Model.MetaTitle ?? Model.Name;

#line default
#line hidden
            BeginContext(101, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("additionalMeta", async() => {
                BeginContext(127, 23, true);
                WriteLiteral("\n    <meta name=\"title\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 150, "\"", 174, 1);
#line 8 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Page/PageDetail.cshtml"
WriteAttributeValue("", 160, ViewBag.Title, 160, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(175, 29, true);
                WriteLiteral(" />\n    <meta name=\"keywords\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 204, "\"", 233, 1);
#line 9 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Page/PageDetail.cshtml"
WriteAttributeValue("", 214, Model.MetaKeywords, 214, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(234, 32, true);
                WriteLiteral(" />\n    <meta name=\"description\"");
                EndContext();
                BeginWriteAttribute("content", " content=\"", 266, "\"", 298, 1);
#line 10 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Page/PageDetail.cshtml"
WriteAttributeValue("", 276, Model.MetaDescription, 276, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(299, 4, true);
                WriteLiteral(" />\n");
                EndContext();
            }
            );
            BeginContext(305, 6, true);
            WriteLiteral("\n<div>");
            EndContext();
            BeginContext(312, 20, false);
#line 13 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Cms/Areas/Cms/Views/Page/PageDetail.cshtml"
Write(Html.Raw(Model.Body));

#line default
#line hidden
            EndContext();
            BeginContext(332, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Cms.Models.Page> Html { get; private set; }
    }
}
#pragma warning restore 1591
