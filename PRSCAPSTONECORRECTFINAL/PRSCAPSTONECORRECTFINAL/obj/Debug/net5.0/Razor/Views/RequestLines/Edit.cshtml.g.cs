#pragma checksum "C:\prs\PRSCAPSTONECORRECTFINAL\PRSCAPSTONECORRECTFINAL\Views\RequestLines\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c75fc9b04a7276a05bdacf73d3d18e96316d24a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RequestLines_Edit), @"mvc.1.0.view", @"/Views/RequestLines/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c75fc9b04a7276a05bdacf73d3d18e96316d24a", @"/Views/RequestLines/Edit.cshtml")]
    public class Views_RequestLines_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PRSCAPSTONECORRECTFINAL.Models.RequestLine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\prs\PRSCAPSTONECORRECTFINAL\PRSCAPSTONECORRECTFINAL\Views\RequestLines\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>RequestLine</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""RequestId"" class=""control-label""></label>
                <select asp-for=""RequestId"" class=""form-control"" asp-items=""ViewBag.RequestId""></select>
                <span asp-validation-for=""RequestId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""ProductId"" class=""control-label""></label>
                <select asp-for=""ProductId"" class=""form-control"" asp-items=""ViewBag.ProductId""></select>
                <span asp-validation-for=""ProductId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Quantity"" class=""control-label""></label>
          ");
            WriteLiteral(@"      <input asp-for=""Quantity"" class=""form-control"" />
                <span asp-validation-for=""Quantity"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\prs\PRSCAPSTONECORRECTFINAL\PRSCAPSTONECORRECTFINAL\Views\RequestLines\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PRSCAPSTONECORRECTFINAL.Models.RequestLine> Html { get; private set; }
    }
}
#pragma warning restore 1591
