#pragma checksum "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\Shared\Components\YorumListeleme\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f6ba6caa65d028661dc6f3e411a91871f2336a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_YorumListeleme_Default), @"mvc.1.0.view", @"/Views/Shared/Components/YorumListeleme/Default.cshtml")]
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
#line 1 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\_ViewImports.cshtml"
using FilmTanitim;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\_ViewImports.cshtml"
using FilmTanitim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f6ba6caa65d028661dc6f3e411a91871f2336a4", @"/Views/Shared/Components/YorumListeleme/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43199b482ad16e61170f00ccfa242b4f71cc3299", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_YorumListeleme_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FilmTanitim.Models.Comment>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\Shared\Components\YorumListeleme\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12\">\r\n        <b>");
#nullable restore
#line 5 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\Shared\Components\YorumListeleme\Default.cshtml"
      Write(item.Movie.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" | ");
#nullable restore
#line 5 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\Shared\Components\YorumListeleme\Default.cshtml"
                              Write(item.CommentTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"float-right text-warning\">");
#nullable restore
#line 5 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\Shared\Components\YorumListeleme\Default.cshtml"
                                                                                         Write(item.MovieRating/10);

#line default
#line hidden
#nullable disable
            WriteLiteral("/5</div></b>\r\n    </div>\r\n    <div class=\"col-12\">\r\n        ");
#nullable restore
#line 8 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\Shared\Components\YorumListeleme\Default.cshtml"
   Write(item.CommentDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <hr />\r\n    <br />\r\n");
#nullable restore
#line 12 "C:\Users\smtun\Desktop\SELÇUK\YAZILIM\ASP.NET CORE MVC\FilmTanitim\FilmTanitim\Views\Shared\Components\YorumListeleme\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n    $(function () {\r\n\r\n        $(\"#rateYoo\").rateYo({\r\n            rating: 3.2,\r\n            rtl: false\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FilmTanitim.Models.Comment>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591