#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Timeline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a5c002dde39617dcfe7275f1b216eb2a7701850"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Timeline), @"mvc.1.0.view", @"/Views/Account/Timeline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Timeline.cshtml", typeof(AspNetCore.Views_Account_Timeline))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5c002dde39617dcfe7275f1b216eb2a7701850", @"/Views/Account/Timeline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d25e4dc576bef9cabc68880ad10e980e158a9a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Timeline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Timeline.cshtml"
   var user = await _userManager.GetUserAsync(User);

#line default
#line hidden
            BeginContext(71, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Timeline.cshtml"
  
    ViewData["Title"] = "Timeline";
    Layout = "~/Views/Shared/_AccountPageLayout.cshtml";

#line default
#line hidden
            BeginContext(175, 35, true);
            WriteLiteral("\r\n<!-- profile section starts -->\r\n");
            EndContext();
            BeginContext(211, 50, false);
#line 10 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Timeline.cshtml"
Write(await  Component.InvokeAsync("_Profile", Model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(261, 31, true);
            WriteLiteral("\r\n<!-- profile section ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591