#pragma checksum "C:\Users\joaomeira\source\repos\WebApplication1\WebApplication1\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bdda430b5814f0086b4401155997f408aa94667"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplication1.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(WebApplication1.Pages.Pages_Index), null)]
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\joaomeira\source\repos\WebApplication1\WebApplication1\Pages\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bdda430b5814f0086b4401155997f408aa94667", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd66e6c0b2d0593b97c0d67f6f506054866fe040", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\joaomeira\source\repos\WebApplication1\WebApplication1\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            BeginContext(71, 149, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>Application Settings</h2>\r\n        <ul>\r\n            <li><h3>Environment Name:</h3><h4>");
            EndContext();
            BeginContext(221, 19, false);
#line 11 "C:\Users\joaomeira\source\repos\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                         Write(ViewData["EnvName"]);

#line default
#line hidden
            EndContext();
            BeginContext(240, 57, true);
            WriteLiteral("</h4></li>\r\n            <li><h3>Level 2 Setting:</h3><h4>");
            EndContext();
            BeginContext(298, 25, false);
#line 12 "C:\Users\joaomeira\source\repos\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                        Write(ViewData["Level2Setting"]);

#line default
#line hidden
            EndContext();
            BeginContext(323, 60, true);
            WriteLiteral("</h4></li>\r\n            <li><h3>Non-sticky Setting:</h3><h4>");
            EndContext();
            BeginContext(384, 28, false);
#line 13 "C:\Users\joaomeira\source\repos\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                           Write(ViewData["NonStickySetting"]);

#line default
#line hidden
            EndContext();
            BeginContext(412, 193, true);
            WriteLiteral("</h4></li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        <h2>Connection Strings</h2>\r\n        <ul>\r\n            <li><h3>Connection String:</h3><h4>");
            EndContext();
            BeginContext(606, 28, false);
#line 21 "C:\Users\joaomeira\source\repos\WebApplication1\WebApplication1\Pages\Index.cshtml"
                                          Write(ViewData["ConnectionString"]);

#line default
#line hidden
            EndContext();
            BeginContext(634, 45, true);
            WriteLiteral("</h4></li>\r\n        </ul>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
