#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Photos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcdaeff3624bdbe12f8cd3a452c7c9dfb0ba99b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Photos), @"mvc.1.0.view", @"/Views/Account/Photos.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Photos.cshtml", typeof(AspNetCore.Views_Account_Photos))]
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
using SciCo.Data;

#line default
#line hidden
#line 3 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\_ViewImports.cshtml"
using SciCo.Models;

#line default
#line hidden
#line 4 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\_ViewImports.cshtml"
using SciCo.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdaeff3624bdbe12f8cd3a452c7c9dfb0ba99b9", @"/Views/Account/Photos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d25e4dc576bef9cabc68880ad10e980e158a9a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Photos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PhotoVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user\'s photos"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Photos.cshtml"
  
    ViewData["Title"] = "Photos";
    Layout = "~/Views/Shared/_AccountPageLayout.cshtml";

#line default
#line hidden
            BeginContext(116, 35, true);
            WriteLiteral("\r\n<!-- profile section starts -->\r\n");
            EndContext();
            BeginContext(152, 54, false);
#line 8 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Photos.cshtml"
Write(await Component.InvokeAsync("_Profile", Model.user.Id));

#line default
#line hidden
            EndContext();
            BeginContext(206, 105, true);
            WriteLiteral("\r\n<!-- profile section ends -->\r\n\r\n<!-- photos section starts -->\r\n<section id=\"userPhotos\">\r\n    <div>\r\n");
            EndContext();
#line 14 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Photos.cshtml"
         foreach (Photo photo in Model.Photos)
        {

#line default
#line hidden
            BeginContext(370, 63, true);
            WriteLiteral("            <div class=\"images\">\r\n                <a href=\"#\"> ");
            EndContext();
            BeginContext(433, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcdaeff3624bdbe12f8cd3a452c7c9dfb0ba99b94983", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 443, "~/img/", 443, 6, true);
#line 17 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Photos.cshtml"
AddHtmlAttributeValue("", 449, photo.Link, 449, 11, false);

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
            BeginContext(482, 27, true);
            WriteLiteral(" </a>\r\n            </div>\r\n");
            EndContext();
#line 19 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Photos.cshtml"
        }

#line default
#line hidden
            BeginContext(520, 52, true);
            WriteLiteral("    </div>\r\n</section>\r\n<!-- photos section ends -->");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> _signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public AppDbContext _db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PhotoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591