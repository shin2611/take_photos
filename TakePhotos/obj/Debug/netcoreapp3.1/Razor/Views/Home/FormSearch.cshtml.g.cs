#pragma checksum "D:\Outsource\take_photos\TakePhotos\Views\Home\FormSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f14e11b9382786acfd101e72c645d22ef74ff01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FormSearch), @"mvc.1.0.view", @"/Views/Home/FormSearch.cshtml")]
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
#line 1 "D:\Outsource\take_photos\TakePhotos\Views\_ViewImports.cshtml"
using TakePhotos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Outsource\take_photos\TakePhotos\Views\_ViewImports.cshtml"
using TakePhotos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f14e11b9382786acfd101e72c645d22ef74ff01", @"/Views/Home/FormSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256061f58417551421c7bcd7cfb8db58c9e481f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FormSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Outsource\take_photos\TakePhotos\Views\Home\FormSearch.cshtml"
  
    ViewData["Title"] = "FormSearch";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!--<div class=\"authincation-content\">\r\n    <div class=\"row no-gutters\">\r\n        <div class=\"col-xl-12\">\r\n            <div class=\"auth-form\">\r\n                <div class=\"text-center mb-3\">-->\r\n");
            WriteLiteral(@"                <!--</div>
                <h4 class=""text-center mb-4"">Account CODE</h4>
                <form action="""">
                    <div class=""form-group"">
                        <label><strong>Mã học viên</strong></label>
                        <input type=""text"" class=""form-control"" value="""" id=""txtStudentCode"" placeholder=""Nhập mã học viên"" >
                    </div>
                    <div class=""text-center"">
                        <button type=""button"" id=""btnSubmit"" onclick=""Search();"" class=""btn btn-primary btn-block"">Submit</button>
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>-->

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
