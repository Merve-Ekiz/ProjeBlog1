#pragma checksum "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82664026470173ea9637f8874aa20f0eca79b762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_PostAdded), @"mvc.1.0.view", @"/Views/Post/PostAdded.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82664026470173ea9637f8874aa20f0eca79b762", @"/Views/Post/PostAdded.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f0a9c3e765d19060fc8c1a926d1506d99bdd02", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_PostAdded : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concreate.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
  
    ViewData["Title"] = "PostAdded";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div  style=\"background-color:cadetblue; border:2px solid black; text-align:center;\">\r\n    <h3>Eklemek istediiniz yeni post bilgilerini giriniz..</h3>\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
 using (Html.BeginForm("PostAdded", "Post", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.Label("Yazı Başlık"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.TextBoxFor(x => x.PostCaption, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.Label("Yazı Durumu"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.TextBoxFor(x => x.PostStatus, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.Label("Oluştuma tarihi"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.TextBoxFor(x => x.CreateDate, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.Label("Kategori"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.TextBoxFor(x => x.CategoryId, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.Label("Yazı İçerik"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
Write(Html.TextAreaFor(x => x.PostContent, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-info\">Kaydet</button>\r\n");
#nullable restore
#line 29 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Post\PostAdded.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concreate.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
