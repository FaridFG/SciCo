#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd3ba2255a5ffd3cc334195c6cccda85fe3609c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Search), @"mvc.1.0.view", @"/Views/Account/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Search.cshtml", typeof(AspNetCore.Views_Account_Search))]
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
#line 1 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\_ViewImports.cshtml"
using SciCo;

#line default
#line hidden
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\_ViewImports.cshtml"
using SciCo.Models;

#line default
#line hidden
#line 3 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\_ViewImports.cshtml"
using SciCo.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd3ba2255a5ffd3cc334195c6cccda85fe3609c", @"/Views/Account/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d5fa73db781f8242b54257c8df7b5994257790", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AppUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user\'s profile photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "~/Views/Shared/_AccountPageLayout.cshtml";

#line default
#line hidden
            BeginContext(129, 28, true);
            WriteLiteral("\r\n<section id=\"searchBar\">\r\n");
            EndContext();
#line 8 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
     if (Model == null)
    {

#line default
#line hidden
            BeginContext(189, 48, true);
            WriteLiteral("        <p>There is no user with this name</p>\r\n");
            EndContext();
#line 11 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(261, 15, true);
            WriteLiteral("        <div>\r\n");
            EndContext();
#line 15 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
         foreach (AppUser user in Model)
        {

#line default
#line hidden
            BeginContext(329, 105, true);
            WriteLiteral("            <div class=\"searchResult\">\r\n                <div class=\"resultAccount\">\r\n                    ");
            EndContext();
            BeginContext(434, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8cd3ba2255a5ffd3cc334195c6cccda85fe3609c5272", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 444, "~/img/", 444, 6, true);
#line 19 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
AddHtmlAttributeValue("", 450, user.ProfilePhoto, 450, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(499, 34, true);
            WriteLiteral("\r\n                    <a href=\"#\">");
            EndContext();
            BeginContext(534, 9, false);
#line 20 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
                           Write(user.Name);

#line default
#line hidden
            EndContext();
            BeginContext(543, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(545, 12, false);
#line 20 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
                                      Write(user.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(557, 93, true);
            WriteLiteral("</a>\r\n                </div>\r\n                <div class=\"showProfile\">\r\n                    ");
            EndContext();
            BeginContext(650, 151, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cd3ba2255a5ffd3cc334195c6cccda85fe3609c7729", async() => {
                BeginContext(656, 138, true);
                WriteLiteral("\r\n                        <input type=\"hidden\">\r\n                        <button type=\"submit\">Show Profile</button>\r\n                    ");
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
            BeginContext(801, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 29 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
        }

#line default
#line hidden
            BeginContext(858, 303, true);
            WriteLiteral(@"    </div>
    <div id=""pagination"">
        <ul>
            <li>
                <a href=""#""> <i class=""fas fa-angle-left""></i>Previous</a>
            </li>
            <li>
                <a href=""#"">Next<i class=""fas fa-angle-right""></i> </a>
            </li>
        </ul>
    </div>
");
            EndContext();
#line 41 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Search.cshtml"
    }

#line default
#line hidden
            BeginContext(1168, 10, true);
            WriteLiteral("</section>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AppUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591