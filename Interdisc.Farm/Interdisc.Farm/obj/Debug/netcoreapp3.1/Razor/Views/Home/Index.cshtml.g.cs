#pragma checksum "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3de0026fa85862401a1deb16c6a8abe62931e40a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/_ViewImports.cshtml"
using Interdisc.Farm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/_ViewImports.cshtml"
using Interdisc.Farm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3de0026fa85862401a1deb16c6a8abe62931e40a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9164fc1f0b41aaa96d2310f2da4a120c3c1a946b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductGroupModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cottonbro.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("poster", new global::Microsoft.AspNetCore.Html.HtmlString("~images/cottenbro.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/cottenbro.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/farmfair-logo1.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("farmfair"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("drawing"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/drawing3.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("growing carrot"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/Home/Index.cshtml"
  
    string GetGroupImageUrl(ProductGroupModel group) => $"/images/" + $"{group.ProductGroupName.ToLower().Replace(' ', '-')}.jpg";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "~/Views/Shared/_Layout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div id=\"hero\">\n    <div class=\"video-container\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("video", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3de0026fa85862401a1deb16c6a8abe62931e40a8640", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("loop", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("autoplay", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3de0026fa85862401a1deb16c6a8abe62931e40a10364", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n    <div class=\"pageHeading\">\n        <h1>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3de0026fa85862401a1deb16c6a8abe62931e40a11436", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h1>\n        <h3 class=\"mCenter description\">Get fresh excess produce and meats directly from the farm</h3>\n    </div>\n\n</div>\n\n<div class=\"gradSectionSolid\"></div>\n    <section id=\"categories\">\n\n        <div class=\"grid-category\">\n");
#nullable restore
#line 28 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/Home/Index.cshtml"
             foreach (var group in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"card\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3de0026fa85862401a1deb16c6a8abe62931e40a13174", async() => {
                WriteLiteral("\n                    <img class=\"cat-overlay\"");
                BeginWriteAttribute("src", " src=\"", 1044, "\"", 1074, 1);
#nullable restore
#line 32 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/Home/Index.cshtml"
WriteAttributeValue("", 1050, GetGroupImageUrl(group), 1050, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\n                    <h3 class=\"cat-overlay\">\n                        ");
#nullable restore
#line 34 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/Home/Index.cshtml"
                   Write(group.ProductGroupName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </h3>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/Home/Index.cshtml"
                                                                    WriteLiteral(group.ProductGroupModelId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\n            </div>\n");
#nullable restore
#line 38 "/Users/jesperrasmussen/Desktop/git/Farmfair/Interdisc.Farm/Interdisc.Farm/Views/Home/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </div>\n\n    </section>\n\n<section id=\"story\" class=\"container\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3de0026fa85862401a1deb16c6a8abe62931e40a16696", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <h2 id=""storyTitle"">Our Story</h2>
    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus imperdiet, nulla et dictum interdum, nisi lorem egestas vitae scel<span id=""dots"">...</span><span id=""more"">erisque enim ligula venenatis dolor. Maecenas nisl est, ultrices nec congue eget, auctor vitae massa. Fusce luctus vestibulum augue ut aliquet. Nunc sagittis dictum nisi, sed ullamcorper ipsum dignissim ac. In at libero sed nunc venenatis imperdiet sed ornare turpis. Donec vitae dui eget tellus gravida venenatis. Integer fringilla congue eros non fermentum. Sed dapibus pulvinar nibh tempor porta.</span></p>
    <div class=""readMore"">
        <a href=""#storyTitle"" class=""downArrow"" onclick=""myFunction()"" id=""myBtn"">&#65516;</a>

    </div>
</section>
<section id=""recipes"">
    <h2>Inspiration</h2>
    <div class=""recipe-filter container"">
        <a href=""#"" class=""btn btn_primary"">Breakfast</a>
        <a href=""#"" class=""btn btn_primary"">Beverages</a>
        <a href=""#"" class=""btn btn_prima");
            WriteLiteral("ry\">Main</a>\n        <a href=\"#\" class=\"btn btn_primary\">Dessert</a>\n        <a href=\"#\" class=\"btn btn_primary\">Appetizers</a>\n    </div>\n    <div class=\"recipe-grid container-small\">\n\n        <div class=\"recipe-card\">\n            <a href=\"#\"");
            BeginWriteAttribute("class", " class=\"", 2664, "\"", 2672, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <img src=\"https://picsum.photos/300/200\"");
            BeginWriteAttribute("alt", " alt=\"", 2731, "\"", 2737, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""recipe-card-info"">
                    <h3 class=""small"">Spaghetti bolognese</h3>
                    <div class=""recipe-card-info-facts"">
                        <div class=""level"">easy</div>
                        <div class=""recipe-time"">30 min</div>
                    </div>
                </div>

            </a>
        </div>
        <div class=""recipe-card"">
            <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 3163, "\"", 3171, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <img src=\"https://picsum.photos/300/200\"");
            BeginWriteAttribute("alt", " alt=\"", 3230, "\"", 3236, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""recipe-card-info"">
                    <h3 class=""small"">Spaghetti bolognese</h3>
                    <div class=""recipe-card-info-facts"">
                        <div class=""level"">easy</div>
                        <div class=""recipe-time"">30 min</div>
                    </div>
                </div>

            </a>
        </div>
        <div class=""recipe-card"">
            <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 3662, "\"", 3670, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <img src=\"https://picsum.photos/300/200\"");
            BeginWriteAttribute("alt", " alt=\"", 3729, "\"", 3735, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""recipe-card-info"">
                    <h3 class=""small"">Spaghetti bolognese</h3>
                    <div class=""recipe-card-info-facts"">
                        <div class=""level"">easy</div>
                        <div class=""recipe-time"">30 min</div>
                    </div>
                </div>

            </a>
        </div>
        <div class=""recipe-card"">
            <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 4161, "\"", 4169, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <img src=\"https://picsum.photos/300/200\"");
            BeginWriteAttribute("alt", " alt=\"", 4228, "\"", 4234, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""recipe-card-info"">
                    <h3 class=""small"">Spaghetti bolognese</h3>
                    <div class=""recipe-card-info-facts"">
                        <div class=""level"">easy</div>
                        <div class=""recipe-time"">30 min</div>
                    </div>
                </div>

            </a>
        </div>
        <div class=""recipe-card"">
            <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 4660, "\"", 4668, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <img src=\"https://picsum.photos/300/200\"");
            BeginWriteAttribute("alt", " alt=\"", 4727, "\"", 4733, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""recipe-card-info"">
                    <h3 class=""small"">Spaghetti bolognese</h3>
                    <div class=""recipe-card-info-facts"">
                        <div class=""level"">easy</div>
                        <div class=""recipe-time"">30 min</div>
                    </div>
                </div>

            </a>
        </div>
        <div class=""recipe-card"">
            <a href=""#""");
            BeginWriteAttribute("class", " class=\"", 5159, "\"", 5167, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <img src=\"https://picsum.photos/300/200\"");
            BeginWriteAttribute("alt", " alt=\"", 5226, "\"", 5232, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <div class=""recipe-card-info"">
                    <h3 class=""small"">Spaghetti bolognese</h3>
                    <div class=""recipe-card-info-facts"">
                        <div class=""level"">easy</div>
                        <div class=""recipe-time"">30 min</div>
                    </div>
                </div>

            </a>
        </div>


    </div>
</section>
<section id=""cta"" class=""cta1"">
    <div class=""container"">
        <div class=""leftArea text"">
            <h2 class=""sun"">It's about more <br> than food waste</h2>
            <h3>Easy support of your local farming community, whilst not compromising on quality.</h3>
        </div>
        <div class=""rightArea"">
            <div class=""signUpBox olive"">

                <h3>Recieve offers of <br>fresh produce near you</h3>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3de0026fa85862401a1deb16c6a8abe62931e40a24298", async() => {
                WriteLiteral("\n                    <input type=\"text\" name=\"full-name\" placeholder=\"Name\">\n                    <input type=\"email\" name=\"email\" placeholder=\"Email\">\n                    <h3><a href=\"#\"><input type=\"submit\" value=\"Sign up now\"");
                BeginWriteAttribute("id", " id=\"", 6314, "\"", 6319, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn_cta\"> <i class=\"feather-chevron-right\"></i></a></h3>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n</section>\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3de0026fa85862401a1deb16c6a8abe62931e40a26122", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductGroupModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
