#pragma checksum "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b3c893543f8a476fa904c8f6f29e02127f57ddb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Payments_Views_Checkout_Payment), @"mvc.1.0.view", @"/Areas/Payments/Views/Checkout/Payment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Payments/Views/Checkout/Payment.cshtml", typeof(AspNetCore.Areas_Payments_Views_Checkout_Payment))]
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
#line 1 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b3c893543f8a476fa904c8f6f29e02127f57ddb", @"/Areas/Payments/Views/Checkout/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe26aff0bbdcef08ea5c392043aec87db666b39", @"/Areas/Payments/Views/_ViewImports.cshtml")]
    public class Areas_Payments_Views_Checkout_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplCommerce.Module.Payments.Areas.Payments.ViewModels.CheckoutPaymentForm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cancel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("logoutForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(83, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
  
    ViewBag.Title = "Payment Information";

#line default
#line hidden
            BeginContext(132, 46, true);
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col-md-8\">\n");
            EndContext();
#line 9 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
         if (TempData["Error"] != null)
        {

#line default
#line hidden
            BeginContext(228, 57, true);
            WriteLiteral("            <div class=\"alert alert-danger\" role=\"alert\">");
            EndContext();
            BeginContext(286, 17, false);
#line 11 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
                                                    Write(TempData["Error"]);

#line default
#line hidden
            EndContext();
            BeginContext(303, 7, true);
            WriteLiteral("</div>\n");
            EndContext();
#line 12 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
        }

#line default
#line hidden
            BeginContext(320, 97, true);
            WriteLiteral("        <div id=\"paymentError\" class=\"alert alert-danger d-none\" role=\"alert\"></div>\n        <h3>");
            EndContext();
            BeginContext(418, 37, false);
#line 14 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
       Write(Localizer["Choose a payment methods"]);

#line default
#line hidden
            EndContext();
            BeginContext(455, 32, true);
            WriteLiteral("</h3>\n        <div class=\"row\">\n");
            EndContext();
#line 16 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
             foreach (var paymentProvider in Model.PaymentProviders)
            {

#line default
#line hidden
            BeginContext(570, 73, true);
            WriteLiteral("                <div class=\"col-sm-12 col-md-6\">\n                    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 643, "\"", 701, 3);
            WriteAttributeValue("", 651, "payment-method", 651, 14, true);
            WriteAttributeValue(" ", 665, "paymentProvider-", 666, 17, true);
#line 19 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
WriteAttributeValue("", 682, paymentProvider.Id, 682, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(702, 2, true);
            WriteLiteral(">\n");
            EndContext();
#line 20 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
                         if (!string.IsNullOrWhiteSpace(paymentProvider.LandingViewComponentName))
                        {
                            

#line default
#line hidden
            BeginContext(858, 69, false);
#line 22 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
                       Write(await Component.InvokeAsync(paymentProvider.LandingViewComponentName));

#line default
#line hidden
            EndContext();
#line 22 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
                                                                                                  
                        }

#line default
#line hidden
            BeginContext(954, 50, true);
            WriteLiteral("                    </div>\n                </div>\n");
            EndContext();
#line 26 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
            }

#line default
#line hidden
            BeginContext(1018, 60, true);
            WriteLiteral("        </div>\n        <div class=\"text-right\">\n            ");
            EndContext();
            BeginContext(1078, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b3c893543f8a476fa904c8f6f29e02127f57ddb10385", async() => {
                BeginContext(1186, 72, true);
                WriteLiteral("\n                <button type=\"submit\" class=\"btn btn-secondary active\">");
                EndContext();
                BeginContext(1259, 25, false);
#line 30 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
                                                                  Write(Localizer["Cancel Order"]);

#line default
#line hidden
                EndContext();
                BeginContext(1284, 22, true);
                WriteLiteral("</button>\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1313, 62, true);
            WriteLiteral("\n        </div>\n    </div>\n    <div class=\"col-md-4\">\n        ");
            EndContext();
            BeginContext(1376, 43, false);
#line 35 "/home/anonymous/DotNetCoreWorkspace/webPayementCore/SimplCommerce-master/src/Modules/SimplCommerce.Module.Payments/Areas/Payments/Views/Checkout/Payment.cshtml"
   Write(await Component.InvokeAsync("OrderSummary"));

#line default
#line hidden
            EndContext();
            BeginContext(1419, 19, true);
            WriteLiteral("\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplCommerce.Module.Payments.Areas.Payments.ViewModels.CheckoutPaymentForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
