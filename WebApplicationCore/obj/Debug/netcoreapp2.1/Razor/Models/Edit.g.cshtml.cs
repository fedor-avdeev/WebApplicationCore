#pragma checksum "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f3b75581993c1ba1ec2ac1b49375a9d6f7698f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Edit), @"mvc.1.0.razor-page", @"/Models/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Models/Edit.cshtml", typeof(AspNetCore.Models_Edit), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3b75581993c1ba1ec2ac1b49375a9d6f7698f6", @"/Models/Edit.cshtml")]
    public class Models_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
            BeginContext(93, 1666, true);
            WriteLiteral(@"
<h2>Edit</h2>

<h4>Movie</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Movie.ID"" />
            <div class=""form-group"">
                <label asp-for=""Movie.Title"" class=""control-label""></label>
                <input asp-for=""Movie.Title"" class=""form-control"" />
                <span asp-validation-for=""Movie.Title"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.ReleaseDate"" class=""control-label""></label>
                <input asp-for=""Movie.ReleaseDate"" class=""form-control"" />
                <span asp-validation-for=""Movie.ReleaseDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.Genre"" class=""control-label""></label>
                <input asp-for=""Movie.Genre"" class=""form-");
            WriteLiteral(@"control"" />
                <span asp-validation-for=""Movie.Genre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.Price"" class=""control-label""></label>
                <input asp-for=""Movie.Price"" class=""form-control"" />
                <span asp-validation-for=""Movie.Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""./Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1777, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 49 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationCore.Models.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationCore.Models.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationCore.Models.EditModel>)PageContext?.ViewData;
        public WebApplicationCore.Models.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
