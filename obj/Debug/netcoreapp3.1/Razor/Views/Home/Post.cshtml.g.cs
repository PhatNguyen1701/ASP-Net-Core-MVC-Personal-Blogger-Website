#pragma checksum "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3e110c43db134d89c87359e223d412b67abcf20"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 1 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\_ViewImports.cshtml"
using Bloger_Project_Practise.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\_ViewImports.cshtml"
using Bloger_Project_Practise.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\_ViewImports.cshtml"
using Bloger_Project_Practise.Models.Commments;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3e110c43db134d89c87359e223d412b67abcf20", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1562215a2a344c26d6a1fa1eac78ba7bc38fb4ba", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/satic/UserPlaceHoverImage.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Blog Image 11"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-weight: 600; color:#808080; text-decoration:underline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Auth", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
  
    ViewBag.Title = Model.Title;
    ViewBag.Description = Model.Description;
    ViewBag.Keywords = $"{Model.Tags?.Replace(",", " ")} {Model.Category}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Home Section -->\r\n\r\n<section id=\"home\" class=\"main-single-post parallax-section\">\r\n    <div class=\"overlay\"></div>\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n            <div class=\"col-md-12 col-sm-12\">\r\n                <h1>");
#nullable restore
#line 17 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
               Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
            </div>

        </div>
    </div>
</section>

<!-- Blog Single Post Section -->

<section id=""blog-single-post"">
    <div class=""container"">
        <div class=""row"">

            <div class=""col-md-offset-1 col-md-10 col-sm-12"">
                <div class=""blog-single-post-thumb"">

                    <div class=""blog-post-title"">
                        <h2>");
#nullable restore
#line 34 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h2>\r\n                    </div>\r\n\r\n                    <div class=\"blog-post-format\">\r\n                        <span><a href=\"#\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d3e110c43db134d89c87359e223d412b67abcf208069", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" Username</a></span>\r\n                        <span><i class=\"fa fa-date\"></i> July 22, 2017</span>\r\n                        <span><a href=\"#\"><i class=\"fa fa-comment-o\"></i> ");
#nullable restore
#line 40 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                                                     Write(Model.MainComments.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></span>\r\n                    </div>\r\n\r\n                    <div class=\"blog-post-des\">\r\n                        <blockquote>");
#nullable restore
#line 44 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                               Write(Model.Tags);

#line default
#line hidden
#nullable disable
            WriteLiteral("</blockquote>\r\n                        <p>");
#nullable restore
#line 45 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 46 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                         if (!String.IsNullOrEmpty(Model.Image))
                        {
                            var image_path = $"/Image/{Model.Image}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"blog-post-image\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 1734, "\"", 1751, 1);
#nullable restore
#line 50 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
WriteAttributeValue("", 1740, image_path, 1740, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-responsive\">\r\n                            </div>\r\n");
#nullable restore
#line 52 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 53 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                      Write(Html.Raw(Model.Body));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n\r\n                    <div class=\"blog-author\">\r\n                        <div class=\"media\">\r\n                            <div class=\"media-object pull-left\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d3e110c43db134d89c87359e223d412b67abcf2012099", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""media-body"">
                                <h3 class=""media-heading""><a href=""#"">Username</a></h3>
                                <p>Author's Blog Infor</p>
                            </div>
                        </div>
                    </div>

                    <!--Comments-->
                    <div class=""blog-comment"">
                        <h3>Comments</h3>
");
#nullable restore
#line 71 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"media\">\r\n                                <div style=\"margin-left: -120px; margin-top: -70px;\">\r\n");
#nullable restore
#line 75 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                      
                                        await Html.RenderPartialAsync("_MainComment", new CommentViewModel { PostId = Model.Id, MainCommentId = 0 });
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </div>\r\n\r\n");
#nullable restore
#line 80 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                 foreach (var c in Model.MainComments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"media-object pull-left\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d3e110c43db134d89c87359e223d412b67abcf2015140", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n");
            WriteLiteral("                                    <div class=\"media-body\">\r\n                                        <h3 class=\"media-heading\">Username</h3>\r\n                                        <span>");
#nullable restore
#line 88 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                         Write(c.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        <p>");
#nullable restore
#line 89 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                      Write(c.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n");
            WriteLiteral("                                    <div style=\"margin-left: 60px; margin-bottom: 60px;\">\r\n\r\n");
#nullable restore
#line 94 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                          
                                            await Html.RenderPartialAsync("_SubComment", new CommentViewModel { PostId = Model.Id, MainCommentId = c.Id });
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 98 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                         foreach (var sc in c.SubComments)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\"media\">\r\n                                                <div class=\"media-object pull-left\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d3e110c43db134d89c87359e223d412b67abcf2018396", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                </div>
                                                <div class=""media-body"">
                                                    <h3 class=""media-heading"">Username</h3>
                                                    <span>");
#nullable restore
#line 106 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                                     Write(sc.Created);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    <p>");
#nullable restore
#line 107 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                                  Write(sc.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                </div>\r\n                                            </div>\r\n");
#nullable restore
#line 110 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n");
#nullable restore
#line 112 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 114 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div style=\"margin-bottom: 30px; margin-top: 10px;\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3e110c43db134d89c87359e223d412b67abcf2021641", async() => {
                WriteLiteral("Sign In");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" to comment on this post!\r\n                            </div>\r\n");
#nullable restore
#line 120 "D:\MyProjects\Bloger_Project_Practise_Import_Template\Bloger_Project_Practise\Views\Home\Post.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
