#pragma checksum "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "877645ca7ca5cdf3ea25f55aa9971b7cda74cadd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Index), @"mvc.1.0.razor-page", @"/Models/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Models/Index.cshtml", typeof(AspNetCore.Models_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877645ca7ca5cdf3ea25f55aa9971b7cda74cadd", @"/Models/Index.cshtml")]
    public class Models_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 156, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    <a asp-page=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(252, 50, false);
#line 17 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Title));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 56, false);
#line 20 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(414, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(470, 50, false);
#line 23 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Genre));

#line default
#line hidden
            EndContext();
            BeginContext(520, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(576, 50, false);
#line 26 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Movie[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(626, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 32 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
 foreach (var item in Model.Movie) {

#line default
#line hidden
            BeginContext(750, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(799, 40, false);
#line 35 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(839, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(895, 46, false);
#line 38 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
            EndContext();
            BeginContext(941, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(997, 40, false);
#line 41 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1093, 40, false);
#line 44 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1133, 75, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-page=\"./Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1208, "\"", 1231, 1);
#line 47 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
WriteAttributeValue("", 1223, item.ID, 1223, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1232, 52, true);
            WriteLiteral(">Edit</a> |\r\n                <a asp-page=\"./Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1284, "\"", 1307, 1);
#line 48 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
WriteAttributeValue("", 1299, item.ID, 1299, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1308, 54, true);
            WriteLiteral(">Details</a> |\r\n                <a asp-page=\"./Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1362, "\"", 1385, 1);
#line 49 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
WriteAttributeValue("", 1377, item.ID, 1377, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1386, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 52 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1436, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationCore.Models.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationCore.Models.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationCore.Models.IndexModel>)PageContext?.ViewData;
        public WebApplicationCore.Models.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
