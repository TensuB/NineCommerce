#pragma checksum "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0520c7416c16b0d530ed4ed3aab5d1a787994bca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_ChangePassword), @"mvc.1.0.view", @"/Views/Customer/ChangePassword.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
#nullable restore
#line 8 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using System.Text.Encodings.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.ViewFeatures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Primitives;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Captcha;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Security.Honeypot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.Themes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Framework.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Boards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Catalog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Checkout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Cms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Customer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Media;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.News;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Newsletter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Order;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Polls;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.PrivateMessages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.ShoppingCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Topics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\_ViewImports.cshtml"
using Nop.Web.Models.Vendors;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0520c7416c16b0d530ed4ed3aab5d1a787994bca", @"/Views/Customer/ChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7654b745a4afa95f40d704ba2b1e9f7718148f30", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_ChangePassword : Nop.Web.Framework.Mvc.Razor.NopRazorPage<ChangePasswordModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("message-error"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-postfix", ":", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "CustomerChangePassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.LabelTagHelper __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper __Nop_Web_Framework_TagHelpers_Public_InputTagHelper;
        private global::Nop.Web.Framework.TagHelpers.Shared.NopRequiredTagHelper __Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
  
    Layout = "_ColumnsTwo";

    //title
    Html.AddTitleParts(T("PageTitle.Account").Text);
    //page class
    Html.AppendPageCssClassParts("html-account-page");
    Html.AppendPageCssClassParts("html-change-password-page");

#line default
#line hidden
#nullable disable
            DefineSection("left", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 13 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
Write(await Component.InvokeAsync("CustomerNavigation", new { selectedTabId = CustomerNavigationEnum.ChangePassword }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"page account-page change-password-page\">\r\n    <div class=\"page-title\">\r\n        <h1>");
#nullable restore
#line 18 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
       Write(T("Account.MyAccount"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 18 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
                                 Write(T("Account.ChangePassword"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div class=\"page-body\">\r\n");
#nullable restore
#line 21 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
         if (!string.IsNullOrEmpty(Model.Result))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"result\">\r\n                ");
#nullable restore
#line 24 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
           Write(Model.Result);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 26 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0520c7416c16b0d530ed4ed3aab5d1a787994bca15366", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0520c7416c16b0d530ed4ed3aab5d1a787994bca15637", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 28 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            <div class=\"fieldset\">\r\n                <div class=\"form-fields\">\r\n                    <div class=\"inputs\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0520c7416c16b0d530ed4ed3aab5d1a787994bca17529", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_LabelTagHelper);
#nullable restore
#line 32 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OldPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For;
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.Postfix = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0520c7416c16b0d530ed4ed3aab5d1a787994bca19716", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 33 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OldPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-required", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0520c7416c16b0d530ed4ed3aab5d1a787994bca21298", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Shared.NopRequiredTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0520c7416c16b0d530ed4ed3aab5d1a787994bca22307", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 35 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.OldPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"inputs\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0520c7416c16b0d530ed4ed3aab5d1a787994bca24041", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_LabelTagHelper);
#nullable restore
#line 38 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For;
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.Postfix = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0520c7416c16b0d530ed4ed3aab5d1a787994bca26228", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 39 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-required", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0520c7416c16b0d530ed4ed3aab5d1a787994bca27810", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Shared.NopRequiredTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0520c7416c16b0d530ed4ed3aab5d1a787994bca28819", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 41 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"inputs\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0520c7416c16b0d530ed4ed3aab5d1a787994bca30553", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_LabelTagHelper);
#nullable restore
#line 44 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ConfirmNewPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.For = __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For;
                __Nop_Web_Framework_TagHelpers_Public_LabelTagHelper.Postfix = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0520c7416c16b0d530ed4ed3aab5d1a787994bca32747", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Public_InputTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Public.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Public_InputTagHelper);
#nullable restore
#line 45 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ConfirmNewPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Nop_Web_Framework_TagHelpers_Public_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("nop-required", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0520c7416c16b0d530ed4ed3aab5d1a787994bca34336", async() => {
                }
                );
                __Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper = CreateTagHelper<global::Nop.Web.Framework.TagHelpers.Shared.NopRequiredTagHelper>();
                __tagHelperExecutionContext.Add(__Nop_Web_Framework_TagHelpers_Shared_NopRequiredTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0520c7416c16b0d530ed4ed3aab5d1a787994bca35345", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 47 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ConfirmNewPassword);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"buttons\">\r\n                <input type=\"submit\" class=\"button-1 change-password-button\"");
                BeginWriteAttribute("value", " value=\"", 2154, "\"", 2197, 1);
#nullable restore
#line 52 "C:\Users\tensa\Documents\Visual Studio 2019\Projects\NopCommerce\nopCommerce_4.30_Source\Presentation\Nop.Web\Views\Customer\ChangePassword.cshtml"
WriteAttributeValue("", 2162, T("Account.ChangePassword.Button"), 2162, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Route = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ChangePasswordModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
