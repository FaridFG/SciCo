#pragma checksum "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6272d2e78256fec0c6dd3aadf51b58fa63d7088c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Friend_ShowFriendRequests), @"mvc.1.0.view", @"/Views/Friend/ShowFriendRequests.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Friend/ShowFriendRequests.cshtml", typeof(AspNetCore.Views_Friend_ShowFriendRequests))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6272d2e78256fec0c6dd3aadf51b58fa63d7088c", @"/Views/Friend/ShowFriendRequests.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d25e4dc576bef9cabc68880ad10e980e158a9a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Friend_ShowFriendRequests : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RequestsVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("user\'s profile photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Timeline", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Friend", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcceptFriendRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFriendRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
  
    ViewData["Title"] = "ShowFriendRequests";
    Layout = "~/Views/Shared/_AccountPageLayout.cshtml";

#line default
#line hidden
            BeginContext(133, 38, true);
            WriteLiteral("\r\n    <section id=\"friend-requests\">\r\n");
            EndContext();
#line 9 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
         if (Model.RequestorUsers.Count() == 0)
        {

#line default
#line hidden
            BeginContext(231, 97, true);
            WriteLiteral("            <div id=\"noRequest\">\r\n                <p>No Friend Requests</p>\r\n            </div>\r\n");
            EndContext();
#line 14 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(364, 19, true);
            WriteLiteral("            <div>\r\n");
            EndContext();
#line 18 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                 foreach (AppUser requestor in Model.RequestorUsers)
                {
                    FriendRequest request = _db.FriendRequests.FirstOrDefault(r => r.RequestorUser == requestor);

#line default
#line hidden
            BeginContext(587, 102, true);
            WriteLiteral("                    <div class=\"requestResult\">\r\n                        <div class=\"resultAccount\">\r\n");
            EndContext();
#line 23 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                             if (!(Model.Photos.Any(p => p.user == requestor && p.isProfilePhoto == true)))
                            {

#line default
#line hidden
            BeginContext(829, 60, true);
            WriteLiteral("                                <span>No<br />Photo</span>\r\n");
            EndContext();
#line 26 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                            }
                            else
                            {
                                

#line default
#line hidden
#line 29 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                                 foreach (Photo photo in Model.Photos.Where(p => p.user == requestor && p.isProfilePhoto == true).TakeLast(1))
                                {

#line default
#line hidden
            BeginContext(1164, 36, true);
            WriteLiteral("                                    ");
            EndContext();
            BeginContext(1200, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6272d2e78256fec0c6dd3aadf51b58fa63d7088c8674", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1210, "~/img/", 1210, 6, true);
#line 31 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
AddHtmlAttributeValue("", 1216, photo.Link, 1216, 11, false);

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
            BeginContext(1258, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                                }

#line default
#line hidden
#line 32 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                                 
                            }

#line default
#line hidden
            BeginContext(1326, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1354, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6272d2e78256fec0c6dd3aadf51b58fa63d7088c10812", async() => {
                BeginContext(1434, 14, false);
#line 34 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                                                                                                      Write(requestor.Name);

#line default
#line hidden
                EndContext();
                BeginContext(1448, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1450, 17, false);
#line 34 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                                                                                                                      Write(requestor.Surname);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                                                                                WriteLiteral(requestor.Id);

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
            BeginContext(1471, 196, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"requestOptions\">\r\n                            <ul>\r\n                                <li>\r\n                                    ");
            EndContext();
            BeginContext(1667, 432, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6272d2e78256fec0c6dd3aadf51b58fa63d7088c14270", async() => {
                BeginContext(1730, 81, true);
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"requestorId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1811, "\"", 1832, 1);
#line 40 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
WriteAttributeValue("", 1819, requestor.Id, 1819, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1833, 82, true);
                WriteLiteral(" />\r\n                                        <input type=\"hidden\" name=\"requestId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1915, "\"", 1934, 1);
#line 41 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
WriteAttributeValue("", 1923, request.Id, 1923, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1935, 157, true);
                WriteLiteral(">\r\n                                        <button href=\"#\" title=\"Confirm\"> <i class=\"fas fa-user-plus\"></i> </button>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2099, 115, true);
            WriteLiteral("\r\n                                </li>\r\n                                <li>\r\n                                    ");
            EndContext();
            BeginContext(2214, 326, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6272d2e78256fec0c6dd3aadf51b58fa63d7088c17417", async() => {
                BeginContext(2277, 79, true);
                WriteLiteral("\r\n                                        <input type=\"hidden\" name=\"requestId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2356, "\"", 2375, 1);
#line 47 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
WriteAttributeValue("", 2364, request.Id, 2364, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2376, 157, true);
                WriteLiteral(">\r\n                                        <button href=\"#\" title=\"Delete\"> <i class=\"fas fa-user-minus\"></i> </button>\r\n                                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2540, 136, true);
            WriteLiteral("\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 54 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
                }

#line default
#line hidden
            BeginContext(2695, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 56 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
             if (Model.RequestorUsers.Count() > 5)
            {

#line default
#line hidden
            BeginContext(2782, 411, true);
            WriteLiteral(@"                <div id=""pagination"">
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
#line 68 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
            }

#line default
#line hidden
#line 68 "C:\Users\farid\Desktop\SciCo\SciCo\SciCo\Views\Friend\ShowFriendRequests.cshtml"
             
        }

#line default
#line hidden
            BeginContext(3219, 14, true);
            WriteLiteral("    </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RequestsVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
