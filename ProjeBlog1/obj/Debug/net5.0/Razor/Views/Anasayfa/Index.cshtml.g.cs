#pragma checksum "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9525ffba96bd2eee62e811ab488713b6546b80f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Anasayfa_Index), @"mvc.1.0.view", @"/Views/Anasayfa/Index.cshtml")]
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
#line 1 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\_ViewImports.cshtml"
using ProjeBlog1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\_ViewImports.cshtml"
using ProjeBlog1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
using EntityLayer.Concreate;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9525ffba96bd2eee62e811ab488713b6546b80f6", @"/Views/Anasayfa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f0a9c3e765d19060fc8c1a926d1506d99bdd02", @"/Views/_ViewImports.cshtml")]
    public class Views_Anasayfa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Post>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<section class=""main-content-w3layouts-agileits"">
    <div class=""container"">
        <h3 class=""tittle"">Blog Posts</h3>
        <div class=""inner-sec"">
            <!--left-->
            <div class=""left-blog-info-w3layouts-agileits text-left"" >
                <div class=""row"">
");
#nullable restore
#line 17 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col-lg-4 card\">\r\n                            <a href=\"single.html\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 646, "\"", 663, 1);
#nullable restore
#line 21 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 652, item.image, 652, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 695, "\"", 701, 0);
            EndWriteAttribute();
            WriteLiteral(@" height=""300"" width=""350"">
                            </a>
                            <div class=""card-body"">
                                <ul class=""blog-icons my-4"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""far fa-calendar-alt""></i> ");
#nullable restore
#line 27 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
                                                                            Write(((DateTime)item.CreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </a>
                                    </li>
                                  
                                    <li>
                                        <a href=""#"">
                                            <i class=""fas fa-eye""></i> ");
#nullable restore
#line 33 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
                                                                  Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </a>\r\n                                    </li>\r\n\r\n                                </ul>\r\n                                <h5 class=\"card-title\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 1657, "\"", 1695, 3);
            WriteAttributeValue("", 1664, "/Anasayfa/ReadAll/", 1664, 18, true);
#nullable restore
#line 39 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 1682, item.PostId, 1682, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1694, "/", 1694, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
                                                                         Write(item.PostCaption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                </h5>\r\n                                <p class=\"card-text mb-3\">");
#nullable restore
#line 41 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
                                                     Write(item.PostContent.Substring(0,item.PostContent.Substring(0,150).LastIndexOf(" ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1941, "\"", 1979, 3);
            WriteAttributeValue("", 1948, "/Anasayfa/ReadAll/", 1948, 18, true);
#nullable restore
#line 42 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
WriteAttributeValue("", 1966, item.PostId, 1966, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1978, "/", 1978, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary read-m\">Devamını Oku</a>\r\n                                <br />\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 46 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Anasayfa\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n                </div>\r\n                <!--//left-->\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Post>> Html { get; private set; }
    }
}
#pragma warning restore 1591
