#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e51461c2265f682c9478caa3013c5c13868a02f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPage_Views_UpdateUser_UpdateUserInfo), @"mvc.1.0.view", @"/Areas/AdminPage/Views/UpdateUser/UpdateUserInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/AdminPage/Views/UpdateUser/UpdateUserInfo.cshtml", typeof(AspNetCore.Areas_AdminPage_Views_UpdateUser_UpdateUserInfo))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e51461c2265f682c9478caa3013c5c13868a02f", @"/Areas/AdminPage/Views/UpdateUser/UpdateUserInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3aaef21511d7529d1b06ac937ccf77bf663014cd", @"/Areas/AdminPage/Views/_ViewImports.cshtml")]
    public class Areas_AdminPage_Views_UpdateUser_UpdateUserInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AdminPage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UpdateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateUserInformation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
   System.Globalization.DateTimeFormatInfo date = new System.Globalization.DateTimeFormatInfo();

#line default
#line hidden
            BeginContext(115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
  
    ViewData["Title"] = "UpdateUserInfo";

#line default
#line hidden
            BeginContext(167, 98, true);
            WriteLiteral("\r\n<div class=\"col-12 mt-5\">\r\n    <div class=\"card\">\r\n        <div class=\"card-body\">\r\n            ");
            EndContext();
            BeginContext(265, 1753, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e51461c2265f682c9478caa3013c5c13868a02f5857", async() => {
                BeginContext(369, 192, true);
                WriteLiteral("\r\n                <div class=\"form-group\">\r\n                    <label for=\"disabledTextInput\">Email</label>\r\n                    <input type=\"text\" id=\"disabledTextInput\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 561, "\"", 587, 1);
#line 14 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
WriteAttributeValue("", 575, Model.Email, 575, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(588, 119, true);
                WriteLiteral(" disabled /><br />\r\n                    <input type=\"text\" id=\"disabledTextInput\" name=\"userEmail\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 707, "\"", 727, 1);
#line 15 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
WriteAttributeValue("", 715, Model.Email, 715, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(728, 222, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"disabledTextInput\">Username</label>\r\n                    <input type=\"text\" id=\"disabledTextInput\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 950, "\"", 979, 1);
#line 19 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
WriteAttributeValue("", 964, Model.UserName, 964, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(980, 118, true);
                WriteLiteral(" disabled /><br />\r\n                    <input type=\"text\" id=\"disabledTextInput\" name=\"userName\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1098, "\"", 1121, 1);
#line 20 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
WriteAttributeValue("", 1106, Model.UserName, 1106, 15, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1122, 141, true);
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"disabledTextInput\">User Role</label>\r\n");
                EndContext();
#line 24 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
                     foreach (var role in ViewBag.UserRole)
                    {

#line default
#line hidden
                BeginContext(1347, 86, true);
                WriteLiteral("                        <input type=\"text\" id=\"disabledTextInput\" class=\"form-control\"");
                EndContext();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1433, "\"", 1452, 1);
#line 26 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
WriteAttributeValue("", 1447, role, 1447, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1453, 20, true);
                WriteLiteral(" disabled /><br />\r\n");
                EndContext();
#line 27 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
                    }

#line default
#line hidden
                BeginContext(1496, 67, true);
                WriteLiteral("                    <select class=\"form-control\" name=\"userRole\">\r\n");
                EndContext();
#line 29 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
                         foreach (var role in _db.Roles)
                        {

#line default
#line hidden
                BeginContext(1648, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1676, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e51461c2265f682c9478caa3013c5c13868a02f10446", async() => {
                    BeginContext(1685, 9, false);
#line 31 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
                               Write(role.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1703, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
                        }

#line default
#line hidden
                BeginContext(1732, 118, true);
                WriteLiteral("                    </select>\r\n                </div>\r\n                <div>\r\n                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1850, "\"", 1867, 1);
#line 36 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Areas\AdminPage\Views\UpdateUser\UpdateUserInfo.cshtml"
WriteAttributeValue("", 1858, Model.Id, 1858, 9, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1868, 143, true);
                WriteLiteral(" name=\"id\" />\r\n                </div>\r\n                <button class=\"btn btn-primary btn-block\">Update User Information</button>\r\n            ");
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2018, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591