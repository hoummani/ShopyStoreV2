#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.News/Areas/News/Views/NewsItem/NewsItemDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7129af50e71f695f21905a64e36dec75b163615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_News_Views_NewsItem_NewsItemDetail), @"mvc.1.0.view", @"/Areas/News/Views/NewsItem/NewsItemDetail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/News/Views/NewsItem/NewsItemDetail.cshtml", typeof(AspNetCore.Areas_News_Views_NewsItem_NewsItemDetail))]
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
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.News/Areas/News/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.News/Areas/News/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#line 3 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.News/Areas/News/Views/_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7129af50e71f695f21905a64e36dec75b163615", @"/Areas/News/Views/NewsItem/NewsItemDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de60e33cc27e4e118bc0808a0e74bae73482b185", @"/Areas/News/Views/_ViewImports.cshtml")]
    public class Areas_News_Views_NewsItem_NewsItemDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.News.Areas.News.ViewModels.NewsItemVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(66, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.News/Areas/News/Views/NewsItem/NewsItemDetail.cshtml"
  
    ViewData["Title"] = Model.Name;

#line default
#line hidden
            BeginContext(108, 80, true);
            WriteLiteral("\n<div class=\"news-detail\">\n    <div class=\"row\">\n        <h3 class=\"news-title\">");
            EndContext();
            BeginContext(189, 10, false);
#line 9 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.News/Areas/News/Views/NewsItem/NewsItemDetail.cshtml"
                          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(199, 55, true);
            WriteLiteral("</h3>\n\n        <div class=\"thumbnail\">\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 254, "\"", 284, 1);
#line 12 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.News/Areas/News/Views/NewsItem/NewsItemDetail.cshtml"
WriteAttributeValue("", 260, Model.ThumbnailImageUrl, 260, 24, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(285, 87, true);
            WriteLiteral(" alt=\"\" />\n        </div>\n        <div class=\"news-item-full-description\">\n            ");
            EndContext();
            BeginContext(373, 27, false);
#line 15 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.News/Areas/News/Views/NewsItem/NewsItemDetail.cshtml"
       Write(Html.Raw(Model.FullContent));

#line default
#line hidden
            EndContext();
            BeginContext(400, 33, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration AppSetting { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.News.Areas.News.ViewModels.NewsItemVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
