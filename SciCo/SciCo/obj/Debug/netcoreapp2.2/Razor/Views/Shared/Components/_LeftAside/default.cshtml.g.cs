#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34dbef2f087395d1ccc7e398e23e9070a92bc34d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components__LeftAside_default), @"mvc.1.0.view", @"/Views/Shared/Components/_LeftAside/default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/_LeftAside/default.cshtml", typeof(AspNetCore.Views_Shared_Components__LeftAside_default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34dbef2f087395d1ccc7e398e23e9070a92bc34d", @"/Views/Shared/Components/_LeftAside/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8b1cdd1e6bdfa13ff9eb743993940bffdcac55b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components__LeftAside_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LeftAside>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 24, true);
            WriteLiteral("\r\n<aside class=\"left\">\r\n");
            EndContext();
#line 4 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml"
     foreach (LeftAside leftAside in Model)
    {

#line default
#line hidden
            BeginContext(107, 29, true);
            WriteLiteral("        <div>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 136, "\"", 158, 1);
#line 7 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml"
WriteAttributeValue("", 143, leftAside.Link, 143, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 159, "\"", 188, 1);
#line 7 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml"
WriteAttributeValue("", 167, leftAside.ColorClass, 167, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(189, 17, true);
            WriteLiteral(" target=\"_blank\">");
            EndContext();
            BeginContext(207, 15, false);
#line 7 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml"
                                                                               Write(leftAside.Title);

#line default
#line hidden
            EndContext();
            BeginContext(222, 20, true);
            WriteLiteral("</a>\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 242, "\"", 264, 1);
#line 8 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml"
WriteAttributeValue("", 249, leftAside.Link, 249, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 265, "\"", 294, 1);
#line 8 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml"
WriteAttributeValue("", 273, leftAside.ColorClass, 273, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(295, 20, true);
            WriteLiteral(" target=\"_blank\"> <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 315, "\"", 343, 1);
#line 8 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml"
WriteAttributeValue("", 323, leftAside.IconClass, 323, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(344, 28, true);
            WriteLiteral("></i> </a>\r\n        </div>\r\n");
            EndContext();
#line 10 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Shared\Components\_LeftAside\default.cshtml"
    }

#line default
#line hidden
            BeginContext(379, 8, true);
            WriteLiteral("</aside>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LeftAside>> Html { get; private set; }
    }
}
#pragma warning restore 1591
