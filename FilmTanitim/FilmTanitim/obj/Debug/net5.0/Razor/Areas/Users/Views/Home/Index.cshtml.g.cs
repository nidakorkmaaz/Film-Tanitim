#pragma checksum "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e2d897f9c3dad4e01b1ca17967b3d01c3960fd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Users_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Users/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\_ViewImports.cshtml"
using FilmTanitim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\_ViewImports.cshtml"
using FilmTanitim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2d897f9c3dad4e01b1ca17967b3d01c3960fd7", @"/Areas/Users/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43199b482ad16e61170f00ccfa242b4f71cc3299", @"/Areas/Users/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Users_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FilmTanitim.Models.Movie>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<h2 style=\"text-align:center;\" class=\"text-primary\">TÜM FİLMLER</h2>\r\n<br />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-3\">\r\n        ");
#nullable restore
#line 11 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
   Write(await Component.InvokeAsync("CategoryList"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-3\">\r\n    <div class=\"card\" style=\"width: 18rem;\">\r\n        <img style=\"height:200px;width:100%;\"");
            BeginWriteAttribute("src", " src=\"", 442, "\"", 464, 1);
#nullable restore
#line 17 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
WriteAttributeValue("", 448, item.MovieImage, 448, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <div class=\"card-body\">\r\n            <h5 class=\"card-title\">");
#nullable restore
#line 19 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
                              Write(item.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"card-text\">");
#nullable restore
#line 20 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
                            Write(item.MovieDescription.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e2d897f9c3dad4e01b1ca17967b3d01c3960fd76118", async() => {
                WriteLiteral("Devamını Oku..");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
                                      WriteLiteral(item.MovieId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("id", " id=\"", 782, "\"", 800, 1);
#nullable restore
#line 22 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
WriteAttributeValue("", 787, item.MovieId, 787, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <br />\r\n</div>\r\n");
#nullable restore
#line 28 "C:\Users\smtun\Desktop\SELÇUK\PC\DİĞER PROJELER\FilmTanitim\FilmTanitim\Areas\Users\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FilmTanitim.Models.Movie>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
