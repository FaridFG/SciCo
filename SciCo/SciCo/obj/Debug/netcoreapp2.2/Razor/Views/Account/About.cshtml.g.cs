#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_About), @"mvc.1.0.view", @"/Views/Account/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/About.cshtml", typeof(AspNetCore.Views_Account_About))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d", @"/Views/Account/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8b1cdd1e6bdfa13ff9eb743993940bffdcac55b", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AppUser>
    {
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
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\About.cshtml"
   System.Globalization.DateTimeFormatInfo date = new System.Globalization.DateTimeFormatInfo();

#line default
#line hidden
#line 3 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_AccountPageLayout.cshtml";

#line default
#line hidden
            BeginContext(214, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(217, 42, false);
#line 8 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\About.cshtml"
Write(await Html.PartialAsync("_ProfilePartial"));

#line default
#line hidden
            EndContext();
            BeginContext(259, 341, true);
            WriteLiteral(@"

<!-- about section starts -->
<section id=""userInfo"">
    <div>
        <h1>Information About User</h1>
        <hr />
        <div class=""information"">
            <div>
                <p>Hometown</p>
            </div>
            <div>
                <p>Imishli, Azerbaijan</p>
                <div>
                    ");
            EndContext();
            BeginContext(600, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d4665", async() => {
                BeginContext(606, 127, true);
                WriteLiteral("\r\n                        <input type=\"text\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(740, 292, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <hr />
        <div class=""information"">
            <div>
                <p>Current City</p>
            </div>
            <div>
                <p>Baku, Azerbaijan</p>
                <div>
                    ");
            EndContext();
            BeginContext(1032, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d6540", async() => {
                BeginContext(1038, 127, true);
                WriteLiteral("\r\n                        <input type=\"text\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(1172, 405, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <hr />
        <div class=""information"">
            <div>
                <p>Places you have lived</p>
            </div>
            <div>
                <ul>
                    <li>Imishli, Azerbaijan</li>
                    <li>Shirvan, Azerbaijan</li>
                </ul>
                <div>
                    ");
            EndContext();
            BeginContext(1577, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d8530", async() => {
                BeginContext(1583, 127, true);
                WriteLiteral("\r\n                        <input type=\"text\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(1717, 225, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        <div class=\"information\">\r\n            <div>\r\n                <p>Birth Date</p>\r\n            </div>\r\n            <div>\r\n                <p>");
            EndContext();
            BeginContext(1943, 18, false);
#line 68 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\About.cshtml"
              Write(Model.Birthday.Day);

#line default
#line hidden
            EndContext();
            BeginContext(1961, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1963, 50, false);
#line 68 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\About.cshtml"
                                  Write(date.GetMonthName(Model.Birthday.Month).ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2013, 49, true);
            WriteLiteral("</p>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(2062, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d11114", async() => {
                BeginContext(2068, 127, true);
                WriteLiteral("\r\n                        <input type=\"text\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(2202, 225, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        <div class=\"information\">\r\n            <div>\r\n                <p>Birth Year</p>\r\n            </div>\r\n            <div>\r\n                <p>");
            EndContext();
            BeginContext(2428, 19, false);
#line 83 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\About.cshtml"
              Write(Model.Birthday.Year);

#line default
#line hidden
            EndContext();
            BeginContext(2447, 49, true);
            WriteLiteral("</p>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(2496, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d13323", async() => {
                BeginContext(2502, 127, true);
                WriteLiteral("\r\n                        <input type=\"text\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(2636, 274, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <hr />
        <div class=""information"">
            <div>
                <p>Gender</p>
            </div>
            <div>
                <p>Male</p>
                <div>
                    ");
            EndContext();
            BeginContext(2910, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d15183", async() => {
                BeginContext(2916, 127, true);
                WriteLiteral("\r\n                        <input type=\"text\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(3050, 460, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <hr />
        <div class=""information"">
            <div>
                <p>Education</p>
            </div>
            <div>
                <ul>
                    <li>Shirvan Turkish Private High School</li>
                    <li>Baku Engineering University</li>
                    <li>Code Academy</li>
                </ul>
                <div>
                    ");
            EndContext();
            BeginContext(3510, 140, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d17229", async() => {
                BeginContext(3516, 127, true);
                WriteLiteral("\r\n                        <input type=\"text\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(3650, 220, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        <div class=\"information\">\r\n            <div>\r\n                <p>Email</p>\r\n            </div>\r\n            <div>\r\n                <p>");
            EndContext();
            BeginContext(3871, 11, false);
#line 132 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\About.cshtml"
              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3882, 49, true);
            WriteLiteral("</p>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(3931, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d19426", async() => {
                BeginContext(3937, 128, true);
                WriteLiteral("\r\n                        <input type=\"email\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(4072, 294, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <hr />
        <div class=""information"">
            <div>
                <p>Phone Number</p>
            </div>
            <div>
                <p>(+994)50-776-30-43</p>
                <div>
                    ");
            EndContext();
            BeginContext(4366, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc2b503e9c4e84de5c2c1b20dfbc3fd7303d58d21307", async() => {
                BeginContext(4372, 126, true);
                WriteLiteral("\r\n                        <input type=\"tel\">\r\n                        <button type=\"submit\">Add</button>\r\n                    ");
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
            BeginContext(4505, 113, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- about section ends -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AppUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
