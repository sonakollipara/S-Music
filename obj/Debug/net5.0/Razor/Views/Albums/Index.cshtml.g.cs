#pragma checksum "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1af952bda28da9f28fdbbef144d5a31314781dc0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Albums_Index), @"mvc.1.0.view", @"/Views/Albums/Index.cshtml")]
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
#line 1 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\_ViewImports.cshtml"
using Smusic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\_ViewImports.cshtml"
using Smusic.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1af952bda28da9f28fdbbef144d5a31314781dc0", @"/Views/Albums/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b225dc155f967a8c252acd3073abae2eb042332", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Albums_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Album>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
  
	ViewData["Title"] = "List of Albums";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-4 col-xs-6 border-primary mb-3"">
            <div class=""card mb-3"" style=""max-width: 540px;"">
                <div class=""row g-0"">
                    <div class=""col-md-12"">
                        <div class=""card-header text-white bg-info"">
                            <p class=""card-text"">
                                <h5 class=""card-title"">
                                    ");
#nullable restore
#line 15 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    
                                        <a class=""text-white float-right""><i class=""bi bi-pencil-square""></i></a>
                                    
                                </h5>
                            </p>
                        </div>
                    </div>
                    <div class=""col-md-6"">
                        <img");
            BeginWriteAttribute("src", " src=\"", 964, "\"", 980, 1);
#nullable restore
#line 24 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
WriteAttributeValue("", 970, item.Logo, 970, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100%\"");
            BeginWriteAttribute("alt", " alt=\"", 994, "\"", 1010, 1);
#nullable restore
#line 24 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
WriteAttributeValue("", 1000, item.Name, 1000, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <div class=\"card-body\">\r\n                            <p class=\"card-text\">");
#nullable restore
#line 28 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
                                            Write(item.Descrption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Name: </b>");
#nullable restore
#line 29 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
                                                         Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>Category: </b>");
#nullable restore
#line 30 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
                                                             Write(item.AlbumCategory);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>ActorName: </b>");
#nullable restore
#line 31 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
                                                              Write(item.ActorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            <p class=\"card-text\"><b>SongName: </b>");
#nullable restore
#line 32 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
                                                             Write(item.SongName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        </div>
                    </div>
                    <div class=""col-md-12"">
                        <div class=""card-footer "">
                            <p class=""card-text"">
                                <a class=""btn btn-outline-primary float-right""><i class=""bi bi-eye-fill""></i> Show Details</a>                               
                            </p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 45 "C:\Users\ksona\OneDrive\Desktop\aug2023practice\SMusic\Views\Albums\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Album>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
