#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83872c409543ed4b61aab2914e2bdaf7d37b1145"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPage_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/AdminPage/Views/Dashboard/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPage/Views/Dashboard/Index.cshtml", typeof(AspNetCore.Areas_AdminPage_Views_Dashboard_Index))]
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
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\_ViewImports.cshtml"
using SciCo.Models;

#line default
#line hidden
#line 3 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\_ViewImports.cshtml"
using SciCo.Data;

#line default
#line hidden
#line 4 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\_ViewImports.cshtml"
using SciCo.Areas.AdminPage.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83872c409543ed4b61aab2914e2bdaf7d37b1145", @"/Areas/AdminPage/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aaef21511d7529d1b06ac937ccf77bf663014cd", @"/Areas/AdminPage/Views/_ViewImports.cshtml")]
    public class Areas_AdminPage_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(43, 20, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> _userManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
