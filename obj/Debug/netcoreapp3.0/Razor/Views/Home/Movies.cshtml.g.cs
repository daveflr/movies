#pragma checksum "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58d16fef75726b6eac086b0ae656a7676ece6800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Movies), @"mvc.1.0.view", @"/Views/Home/Movies.cshtml")]
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
#line 1 "C:\Users\Dave\Documents\DotNetCore\movies\Views\_ViewImports.cshtml"
using movies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dave\Documents\DotNetCore\movies\Views\_ViewImports.cshtml"
using movies.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58d16fef75726b6eac086b0ae656a7676ece6800", @"/Views/Home/Movies.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d62e5e369b0500fc5cf092f254c0ebd7a1f0c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Movies : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<movies.Models.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"ui raised inverted segment movie-segment\">\r\n    <div class=\"ui cards\">\r\n");
#nullable restore
#line 5 "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml"
         foreach (var movie in @Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"ui card ml-1\" style=\"width: 154px;\">\r\n                <div class=\"image\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 301, "\"", 362, 1);
#nullable restore
#line 9 "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml"
WriteAttributeValue("", 307, "https://image.tmdb.org/t/p/w154" + @movie.ImagePath, 307, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"visible content\" style=\"height: 180px;\"");
            BeginWriteAttribute("alt", " alt=\"", 410, "\"", 416, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"content\">\r\n                    <a class=\"header\" data-tooltip=\"");
#nullable restore
#line 12 "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml"
                                               Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-position=\"bottom right\" data-inverted=\"\">\r\n                        ");
#nullable restore
#line 13 "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml"
                   Write(movie.Title.Substring(0, Math.Min(movie.Title.Length, 20)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"meta\">\r\n                        <span class=\"date\">");
#nullable restore
#line 16 "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml"
                                      Write(movie.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n                <div class=\"extra content\">\r\n                    Rating:\r\n                    <div class=\"ui yellow disabled rating\" data-rating=\"");
#nullable restore
#line 21 "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml"
                                                                   Write(movie.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-max-rating=\"5\"></div>\r\n                    <div>\r\n                        <i class=\"comment icon\"></i> Comments: ");
#nullable restore
#line 23 "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml"
                                                          Write(movie.Comments.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 28 "C:\Users\Dave\Documents\DotNetCore\movies\Views\Home\Movies.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<movies.Models.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591