#pragma checksum "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/Shared/Components/Account/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33328e06bb62469bf5ce2b93ed068f31a22c2d55"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookstoreProject.Views.Shared.Components.Account.Views_Shared_Components_Account_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Account/Default.cshtml")]
namespace BookstoreProject.Views.Shared.Components.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 4 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/_ViewImports.cshtml"
using BookstoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/_ViewImports.cshtml"
using BookstoreProject.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/_ViewImports.cshtml"
using BookstoreProject.Infrastructure;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33328e06bb62469bf5ce2b93ed068f31a22c2d55", @"/Views/Shared/Components/Account/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"124e3462cc029d29d8821f7e6726bffb392b4b3f", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Account_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoginModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/account/login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 28, "\"", 36, 0);
            EndWriteAttribute();
            WriteLiteral(">\n");
#nullable restore
#line 6 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/Shared/Components/Account/Default.cshtml"
     if (Model.Username == "Admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <small class=\"navbar-text\">\n            <b>Welcom</b>\n            ");
#nullable restore
#line 10 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/Shared/Components/Account/Default.cshtml"
       Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </small>\n");
#nullable restore
#line 12 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/Shared/Components/Account/Default.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33328e06bb62469bf5ce2b93ed068f31a22c2d555646", async() => {
                WriteLiteral("\n            Login\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-returnurl", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/Shared/Components/Account/Default.cshtml"
                                                                                      WriteLiteral(ViewContext.HttpContext.Request.PathandQuery());

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["returnurl"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-returnurl", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["returnurl"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 18 "/Users/janae/Desktop/IS 413/BookstoreProject-Mission10Part2/Views/Shared/Components/Account/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591