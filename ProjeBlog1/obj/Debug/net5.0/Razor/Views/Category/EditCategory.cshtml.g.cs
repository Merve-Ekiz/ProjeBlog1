#pragma checksum "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Category\EditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77b641d4af7fc5a380aa997f58bfb59fe176cf6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_EditCategory), @"mvc.1.0.view", @"/Views/Category/EditCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b641d4af7fc5a380aa997f58bfb59fe176cf6e", @"/Views/Category/EditCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45f0a9c3e765d19060fc8c1a926d1506d99bdd02", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_EditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concreate.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Category\EditCategory.cshtml"
  
    ViewData["Title"] = "EditCategory";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>EditCategory Sayfası</h1>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Category\EditCategory.cshtml"
 using (Html.BeginForm("EditCategory", "Category", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Category\EditCategory.cshtml"
Write(Html.Label("Kategori Adı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Category\EditCategory.cshtml"
Write(Html.HiddenFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Category\EditCategory.cshtml"
Write(Html.TextBoxFor(x => x.CategoryName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 16 "C:\Users\Samsung\source\repos\ProjeBlog1\ProjeBlog1\Views\Category\EditCategory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concreate.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
