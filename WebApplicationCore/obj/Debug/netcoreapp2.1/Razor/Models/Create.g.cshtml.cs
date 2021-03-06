#pragma checksum "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a84a0fe84bb5100511c270d133c7672e055b87e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Models_Create), @"mvc.1.0.razor-page", @"/Models/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Models/Create.cshtml", typeof(AspNetCore.Models_Create), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a84a0fe84bb5100511c270d133c7672e055b87e", @"/Models/Create.cshtml")]
    public class Models_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
            BeginContext(97, 1612, true);
            WriteLiteral(@"
<h2>Create</h2>

<h4>Movie</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
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
                <input asp-for=""Movie.Genre"" class=""form-control"" />
                <span asp-validation-for=");
            WriteLiteral(@"""Movie.Genre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Movie.Price"" class=""control-label""></label>
                <input asp-for=""Movie.Price"" class=""form-control"" />
                <span asp-validation-for=""Movie.Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-page=""Index"">Back to List</a>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1727, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 48 "C:\vs2017\source\repos\WebApplicationCore\WebApplicationCore\Models\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationCore.Models.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationCore.Models.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationCore.Models.CreateModel>)PageContext?.ViewData;
        public WebApplicationCore.Models.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
