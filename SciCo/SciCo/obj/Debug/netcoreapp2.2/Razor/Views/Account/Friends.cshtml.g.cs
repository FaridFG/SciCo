#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a4374001d8e7c8d55ac6d7b081e53d643ebde63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Friends), @"mvc.1.0.view", @"/Views/Account/Friends.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Friends.cshtml", typeof(AspNetCore.Views_Account_Friends))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a4374001d8e7c8d55ac6d7b081e53d643ebde63", @"/Views/Account/Friends.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d25e4dc576bef9cabc68880ad10e980e158a9a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Friends : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FriendVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("profile photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("cover photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Timeline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
   AppUser user = await _userManager.GetUserAsync(User);

#line default
#line hidden
            BeginContext(76, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
  
    ViewData["Title"] = "Friends";
    Layout = "~/Views/Shared/_AccountPageLayout.cshtml";

#line default
#line hidden
            BeginContext(179, 35, true);
            WriteLiteral("\r\n<!-- profile section starts -->\r\n");
            EndContext();
            BeginContext(215, 58, false);
#line 10 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
Write(await Component.InvokeAsync("_Profile", Model.MainUser.Id));

#line default
#line hidden
            EndContext();
            BeginContext(273, 100, true);
            WriteLiteral("\r\n<!-- profile section ends -->\r\n\r\n<!-- friends section starts -->\r\n    <section id=\"userFriends\">\r\n");
            EndContext();
#line 15 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
         if (Model.Friends.Count() == 0)
        {
            if (Model.MainUser == user)
            {

#line default
#line hidden
            BeginContext(482, 117, true);
            WriteLiteral("                <div id=\"noFriend\">\r\n                    <p>Your friends list is empty!</p>\r\n                </div>\r\n");
            EndContext();
#line 22 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(647, 68, true);
            WriteLiteral("                <div id=\"noFriend\">\r\n                    <p><strong>");
            EndContext();
            BeginContext(716, 19, false);
#line 26 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                          Write(Model.MainUser.Name);

#line default
#line hidden
            EndContext();
            BeginContext(735, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(737, 22, false);
#line 26 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                               Write(Model.MainUser.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(759, 64, true);
            WriteLiteral("</strong>\'s friends list is empty!</p>\r\n                </div>\r\n");
            EndContext();
#line 28 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
            }
        }
        else
        {

#line default
#line hidden
            BeginContext(874, 19, true);
            WriteLiteral("            <div>\r\n");
            EndContext();
#line 33 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                 foreach (AppUser friend in Model.FriendUsers)
                {

#line default
#line hidden
            BeginContext(976, 108, true);
            WriteLiteral("                    <div class=\"friend\">\r\n                        <div>\r\n                            <div>\r\n");
            EndContext();
#line 38 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                 if (!(Model.Photos.Any(p => p.user == friend && p.isCoverPhoto == true)))
                                {

#line default
#line hidden
            BeginContext(1227, 56, true);
            WriteLiteral("                                    <p>Cover Photo</p>\r\n");
            EndContext();
#line 41 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                }
                                else
                                {
                                    foreach (Photo photo in Model.Photos.Where(p => p.user == friend && p.isCoverPhoto == true).TakeLast(1))
                                    {

#line default
#line hidden
            BeginContext(1572, 53, true);
            WriteLiteral("                                        <a href=\"#\"> ");
            EndContext();
            BeginContext(1625, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1a4374001d8e7c8d55ac6d7b081e53d643ebde639235", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1635, "~/img/", 1635, 6, true);
#line 46 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
AddHtmlAttributeValue("", 1641, photo.Link, 1641, 11, false);

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
            BeginContext(1674, 7, true);
            WriteLiteral(" </a>\r\n");
            EndContext();
#line 47 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(1755, 71, true);
            WriteLiteral("                            </div>\r\n                            <div>\r\n");
            EndContext();
#line 51 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                 if (!(Model.Photos.Any(p => p.user == friend && p.isProfilePhoto == true)))
                                {

#line default
#line hidden
            BeginContext(1971, 61, true);
            WriteLiteral("                                    <p>Profile<br>Photo</p>\r\n");
            EndContext();
#line 54 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                }
                                else
                                {
                                    foreach (Photo photo in Model.Photos.Where(p => p.user == friend && p.isProfilePhoto == true).TakeLast(1))
                                    {

#line default
#line hidden
            BeginContext(2323, 53, true);
            WriteLiteral("                                        <a href=\"#\"> ");
            EndContext();
            BeginContext(2376, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a4374001d8e7c8d55ac6d7b081e53d643ebde6312237", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2386, "~/img/", 2386, 6, true);
#line 59 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
AddHtmlAttributeValue("", 2392, photo.Link, 2392, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2425, 7, true);
            WriteLiteral(" </a>\r\n");
            EndContext();
#line 60 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(2506, 207, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <div>\r\n                            <ul>\r\n                                <li>\r\n                                    ");
            EndContext();
            BeginContext(2713, 108, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4374001d8e7c8d55ac6d7b081e53d643ebde6314401", async() => {
                BeginContext(2790, 11, false);
#line 67 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                                                                                           Write(friend.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2801, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(2803, 14, false);
#line 67 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                                                                                                        Write(friend.Surname);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                                                                                        WriteLiteral(friend.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2821, 557, true);
            WriteLiteral(@"
                                </li>
                                <li id=""friendOptions"">
                                    <a href=""#""> <i class=""fas fa-ellipsis-h""></i> </a>
                                    <ul>
                                        <li> <a href=""#"">Unfriend</a> </li>
                                        <li> <a href=""#"">Block</a> </li>
                                    </ul>
                                </li>
                            </ul>
                        </div>
                    </div>
");
            EndContext();
#line 79 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
                }

#line default
#line hidden
            BeginContext(3397, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 81 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
        }

#line default
#line hidden
            BeginContext(3428, 49, true);
            WriteLiteral("    </section>\r\n<!-- friends section ends -->\r\n\r\n");
            EndContext();
            BeginContext(3478, 62, false);
#line 85 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
Write(await  Html.PartialAsync("_MessageBoxPartial", Model.MainUser));

#line default
#line hidden
            EndContext();
            BeginContext(3540, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3545, 41, false);
#line 87 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
Write(await  Html.PartialAsync("_PhotoPartial"));

#line default
#line hidden
            EndContext();
            BeginContext(3586, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3591, 48, false);
#line 89 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
Write(await  Html.PartialAsync("_ProfilePhotoPartial"));

#line default
#line hidden
            EndContext();
            BeginContext(3639, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(3644, 46, false);
#line 91 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Account\Friends.cshtml"
Write(await  Html.PartialAsync("_CoverPhotoPartial"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FriendVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
