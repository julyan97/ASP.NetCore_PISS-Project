#pragma checksum "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb442cd45d973bbd8a3118b481621af2f2226d16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RoomChat), @"mvc.1.0.view", @"/Views/Home/RoomChat.cshtml")]
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
#nullable restore
#line 1 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\_ViewImports.cshtml"
using MovieNight;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\_ViewImports.cshtml"
using MovieNight.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb442cd45d973bbd8a3118b481621af2f2226d16", @"/Views/Home/RoomChat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54e59f1218e96968cfb1ab6a910eb6fe20e03dac", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RoomChat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieNight.Models.ModelView.RoomChatModelView>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chat.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
  
    ViewData["Title"] = "ChatRoom";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center h-100\">\r\n\r\n    <div class=\"row text-white align-text-top\">\r\n        <div class=\"col-lg-12\">\r\n            <div class=\"ibox float-e-margins\">\r\n                <div class=\"ibox-content\">\r\n                    <strong>Chat room:  ");
#nullable restore
#line 12 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
                                   Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </strong>
                </div>
            </div>
        </div>
    </div>

    <div style=""margin-bottom:2.5%"">
        <input class=""d-inline-block w-25"" placeholder=""Movie URL"" type=""text"" id=""videom"" />
        <input class=""d-inline-block"" type=""button"" id=""videob"" value=""Start Watching"" />
    </div>

    <div class=""h-100"">
        <link href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">
        <div class=""container text-white d-inline-block align-text-top"">
            <div class=""wrapper wrapper-content animated fadeInRight"">

                <div class=""row text-white"">
                    <div class=""col-lg-12"">
                        <div class=""ibox chat-view"">
                            <div class=""ibox-title"">
                                <small class=""pull-right text-muted"">Last message:  Mon Jan 26 2015 - 18:39:23</small> Chat room panel
                            </div>
                            <div class=""");
            WriteLiteral(@"ibox-content"">
                                <div class=""row"">
                                    <div class=""col-md-9 "">
                                        <div class=""chat-discussion"" id=""messagesList"" style="" background: rgba(0, 0, 0, 0.3); color: white;"">


                                        </div>

                                    </div>
                                    <div class=""col-md-3"">
                                        <div class=""chat-users"" id=""users"">


                                            <div class=""users-list"">
                                                <div class=""chat-user"">
                                                    <img class=""chat-avatar"" src=""https://bootdey.com/img/Content/avatar/avatar8.png""");
            BeginWriteAttribute("alt", " alt=\"", 2169, "\"", 2175, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                    <div class=""chat-user-name"">
                                                        <a href=""#"">Janet Smith</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-lg-12"">
                                        <div class=""chat-message-form"">
                                            <div class=""form-group"">
                                                <textarea class=""d-inline-block form-control message-input"" id=""messageInput"" name=""message"" placeholder=""Enter message text and press enter""></textarea>
                                                <input class=""d-inline-block col btn-secondary b");
            WriteLiteral(@"tn-lg"" type=""button"" id=""sendButton"" value=""Send Message"" />
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="" text-white row d-inline-block align-text-top"">
            <div class=""col-6"">

                <div class=""mt-2"" id=""video"" style=""width: 420px; min-height:315px;padding:3%; background:rgba(0, 0, 0, 0.5);  "">
                    <p class=""text-white"">The movie/video will be displayed here</p>
                    <div id=""generate"">

                    </div>
                    <video width=""400"" id=""displayvid"" controls >
                    </video>

                    <button id=""changeTime"" class=""btn btn-outline-success my-2 my-sm-0"">Change Time For Every One</button>

    ");
            WriteLiteral(@"                <button id=""pausePlay"" class=""btn btn-outline-success my-2 my-sm-0"" onclick=""playPause()"">Play/Pause</button>


                </div>
            </div>
        </div>
        <ul id=""library"" class=""position-fixed align-text-top"" style=""background :rgba(0, 0, 0, 0.5);min-width:8%;min-height:100%;top:0;right:0  "">
            <p class=""text-white"">Movies</p>
");
#nullable restore
#line 95 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
             foreach (var el in Model.Movies)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li");
            BeginWriteAttribute("onclick", " onclick=\"", 4691, "\"", 4722, 3);
            WriteAttributeValue("", 4701, "loadVideo(\'", 4701, 11, true);
#nullable restore
#line 97 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
WriteAttributeValue("", 4712, el.Path, 4712, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4720, "\')", 4720, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-white\" style=\"cursor: pointer;\">");
#nullable restore
#line 97 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
                                                                                           Write(el.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 98 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </ul>
    </div>

</div>
<script>

    function appearLibrary() {
        var el = document.getElementById('library');
        if (el.style.display == ""none"")
            el.style.display = ""inline-block"";
        else
            el.style.display = ""none"";

    }
</script>

<style>


    /* WRAPPERS */
    #wrapper {
        width: 100%;
        overflow-x: hidden;
    }

    .wrapper {
        padding: 0 20px;
    }

    .wrapper-content {
        padding: 20px 10px 40px;
    }

    #page-wrapper {
        padding: 0 15px;
        min-height: 568px;
        position: relative !important;
    }

    ");
            WriteLiteral(@"@media (min-width: 768px) {
        #page-wrapper {
            position: inherit;
            margin: 0 0 0 240px;
            min-height: 2002px;
        }
    }


    .message-input {
        height: 90px !important;
    }

    .chat-avatar {
        height: 36px;
        float: left;
        margin-right: 10px;
    }

    .chat-user-name {
        padding: 10px;
    }

    .chat-user {
        padding: 8px 10px;
        border-bottom: 1px solid rgba(0, 0, 0, 0.3);
    }

        .chat-user a {
            color: inherit;
        }

    .chat-view {
        z-index: 20012;
    }

    .chat-users,
    .chat-statistic {
        margin-left: -30px;
    }

    ");
            WriteLiteral(@"@media (max-width: 992px) {
        .chat-users,
        .chat-statistic {
            margin-left: 0;
        }
    }

    .chat-view .ibox-content {
        padding: 0;
    }

    .chat-message {
        padding: 10px 20px;
    }

    .message-avatar {
        height: 48px;
        width: 48px;
        border: 1px solid rgba(0, 0, 0, 0.3);
        border-radius: 4px;
        margin-top: 1px;
    }

    .chat-discussion .chat-message.left .message-avatar {
        float: left;
        margin-right: 10px;
    }

    .chat-discussion .chat-message.right .message-avatar {
        float: right;
        margin-left: 10px;
    }

    .message {
        background: rgba(0, 0, 0, 0.3);
        border: 1px solid rgba(0, 0, 0, 0.3);
        text-align: left;
        display: block;
        padding: 10px 20px;
        position: relative;
        border-radius: 4px;
    }

    .chat-discussion .chat-message.left .message-date {
        float: right;
    }

    .chat-discuss");
            WriteLiteral(@"ion .chat-message.right .message-date {
        float: left;
    }

    .chat-discussion .chat-message.left .message {
        text-align: left;
        margin-left: 55px;
    }

    .chat-discussion .chat-message.right .message {
        text-align: right;
        margin-right: 55px;
    }

    .message-date {
        font-size: 10px;
        color: #888888;
    }

    .message-content {
        display: block;
    }

    .chat-discussion {
        background: #eee;
        padding: 15px;
        height: 400px;
        overflow-y: auto;
    }

    .chat-users {
        overflow-y: auto;
        height: 400px;
    }

    .chat-message-form .form-group {
        margin-bottom: 0;
    }

    .ibox {
        clear: both;
        margin-bottom: 25px;
        margin-top: 0;
        padding: 0;
    }

        .ibox.collapsed .ibox-content {
            display: none;
        }

        .ibox.collapsed .fa.fa-chevron-up:before {
            content: ""\f078"";
      ");
            WriteLiteral(@"  }

        .ibox.collapsed .fa.fa-chevron-down:before {
            content: ""\f077"";
        }

        .ibox:after,
        .ibox:before {
            display: table;
        }

    .ibox-title {
        -moz-border-bottom-colors: none;
        -moz-border-left-colors: none;
        -moz-border-right-colors: none;
        -moz-border-top-colors: none;
        background-color: rgba(0, 0, 0, 0.3);
        border-color: rgba(0, 0, 0, 0.3);
        border-image: none;
        border-style: solid solid none;
        border-width: 3px 0 0;
        color: inherit;
        margin-bottom: 0;
        padding: 14px 15px 7px;
        min-height: 48px;
    }

    .ibox-content {
        background-color: rgba(0, 0, 0, 0.3);
        color: inherit;
        padding: 15px 20px 20px 20px;
        border-color: rgba(0, 0, 0, 0.3);
        border-image: none;
        border-style: solid solid none;
        border-width: 1px 0;
    }

    .ibox-footer {
        color: inherit;
        ");
            WriteLiteral(@"border-top: 1px solid rgba(0, 0, 0, 0.3);
        font-size: 90%;
        background: rgba(0, 0, 0, 0.3);
        padding: 10px 15px;
    }

    .message-input {
        height: 90px !important;
    }

    .form-control, .single-line {
        background-color: rgba(0, 0, 0, 0.3);
        background-image: none;
        border: 1px solid rgba(0, 0, 0, 0.3);
        border-radius: 1px;
        color: inherit;
        display: block;
        padding: 6px 12px;
        transition: border-color 0.15s ease-in-out 0s, box-shadow 0.15s ease-in-out 0s;
        width: 100%;
        font-size: 14px;
    }
</style>
<script>
        var room = '");
#nullable restore
#line 341 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
               Write(Html.Raw(Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        var curuser = \'");
#nullable restore
#line 342 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
                  Write(Html.Raw(User.Identity.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        var users = ");
#nullable restore
#line 343 "C:\Users\julyan97\Desktop\MovieNight\MovieNight\Views\Home\RoomChat.cshtml"
               Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.Users)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n\r\n</script>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb442cd45d973bbd8a3118b481621af2f2226d1616635", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb442cd45d973bbd8a3118b481621af2f2226d1617675", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieNight.Models.ModelView.RoomChatModelView> Html { get; private set; }
    }
}
#pragma warning restore 1591
