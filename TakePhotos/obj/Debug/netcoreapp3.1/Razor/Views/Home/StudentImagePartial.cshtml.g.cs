#pragma checksum "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f9b4eadbaeae88d048a4b76d5254bb5f6c9032e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentImagePartial), @"mvc.1.0.view", @"/Views/Home/StudentImagePartial.cshtml")]
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
#nullable restore
#line 1 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f9b4eadbaeae88d048a4b76d5254bb5f6c9032e", @"/Views/Home/StudentImagePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256061f58417551421c7bcd7cfb8db58c9e481f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StudentImagePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Photos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""card"">
            <div class=""card-header"">
                <h4 class=""card-title"">Danh sách học viên dự thi</h4>
            </div>
            <div class=""card-body pb-1"">
                <div id=""lightgallery"" class=""row"">
");
#nullable restore
#line 12 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
                     if (Model != null && Model.Count > 0)
                    {
                        foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 543, "\"", 564, 1);
#nullable restore
#line 16 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
WriteAttributeValue("", 550, item.ImageUrl, 550, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-exthumbimage=\"");
#nullable restore
#line 16 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
                                                                   Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-src=\"");
#nullable restore
#line 16 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
                                                                                             Write(item.ImageUrl);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" class=\"col-lg-2 col-md-6 mb-4\">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 696, "\"", 716, 1);
#nullable restore
#line 17 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
WriteAttributeValue("", 702, item.ImageUrl, 702, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 717, "\"", 723, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100%;\" />\r\n                                <span class=\"span-item\">Mã học viên : <b style=\"color:blue\">");
#nullable restore
#line 18 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
                                                                                       Write(item.StudentCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                                <br />\r\n                                <span class=\"span-item\">Số máy : <b style=\"color:red;\">");
#nullable restore
#line 20 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
                                                                                  Write(item.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></span>\r\n                            </a>\r\n");
#nullable restore
#line 22 "D:\Outsource\take_photos\TakePhotos\Views\Home\StudentImagePartial.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /# card -->\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Photos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
