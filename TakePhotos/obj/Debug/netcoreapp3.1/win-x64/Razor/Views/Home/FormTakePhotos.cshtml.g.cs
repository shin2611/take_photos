#pragma checksum "D:\Outsource\take_photos\TakePhotos\Views\Home\FormTakePhotos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bac0e8987962c088d965c8713855a158e0cd3ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FormTakePhotos), @"mvc.1.0.view", @"/Views/Home/FormTakePhotos.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bac0e8987962c088d965c8713855a158e0cd3ee", @"/Views/Home/FormTakePhotos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256061f58417551421c7bcd7cfb8db58c9e481f1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FormTakePhotos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/images/demo_kyc.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:340px;height:515px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Outsource\take_photos\TakePhotos\Views\Home\FormTakePhotos.cshtml"
  
    ViewData["Title"] = "FormTakePhotos";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-12\">\r\n    <div class=\"jumbotron\" style=\"margin-top:20px;padding:20px;text-align:center;\">\r\n        <input type=\"hidden\" id=\"StudentCode2\"");
            BeginWriteAttribute("value", " value=\"", 255, "\"", 283, 1);
#nullable restore
#line 8 "D:\Outsource\take_photos\TakePhotos\Views\Home\FormTakePhotos.cshtml"
WriteAttributeValue("", 263, ViewBag.StudentCode, 263, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"StudentName\"");
            BeginWriteAttribute("value", " value=\"", 334, "\"", 362, 1);
#nullable restore
#line 9 "D:\Outsource\take_photos\TakePhotos\Views\Home\FormTakePhotos.cshtml"
WriteAttributeValue("", 342, ViewBag.StudentName, 342, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <input type=\"hidden\" id=\"OrderNumber\"");
            BeginWriteAttribute("value", " value=\"", 413, "\"", 441, 1);
#nullable restore
#line 10 "D:\Outsource\take_photos\TakePhotos\Views\Home\FormTakePhotos.cshtml"
WriteAttributeValue("", 421, ViewBag.OrderNumber, 421, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        <p><span id=""errorMsg""></span></p>
        <div class=""row"">
            <div class=""col-lg-8"">
                <!-- Here we streaming video from webcam -->
                <h4>
                    Bạn hãy cầm thẻ để trước ngực, mặt hướng vào camera để chụp ảnh.<p /> Hình ảnh sẽ được ghi lại sau <b><span id=""timeCountDown""></span></b>
                </h4>
                <video id=""video"" playsinline autoplay></video>
            </div>

            <div class=""col-lg-4"">
                <h4>
                    Hình ảnh minh họa
                </h4>
                <div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0bac0e8987962c088d965c8713855a158e0cd3ee6080", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
            WriteLiteral(@"            </div>
            <canvas style=""border:solid 1px #ddd;background-color:white;display:none;"" id=""canvas"" width=""475"" height=""475""></canvas>
        </div>
    </div>
</div>




<script type=""text/javascript"">
    
    
    var video = document.querySelector(""#video"");
    var displayTime = document.querySelector(""#timeCountDown"");
    // Basic settings for the video to get from Webcam
    const constraints = {
        audio: false,
        video: {
            width: 600, height: 475
        }
    };

    // This condition will ask permission to user for Webcam access
    if (navigator.mediaDevices.getUserMedia) {
        navigator.mediaDevices.getUserMedia(constraints)
            .then(function (stream) {
                video.srcObject = stream;
            })
            .catch(function (err0r) {
                console.log(""Something went wrong!"");
            });
    }

    var timer = 6;
    const myInterval = setInterval(myTimer, 1000);
    function myTi");
            WriteLiteral(@"mer() {
        if (--timer <= 0) {
            Capture();
            clearInterval(myInterval);
        }
        $(""#timeCountDown"").html(timer);
    }
   
    function stop(e) {
        var stream = video.srcObject;
        var tracks = stream.getTracks();

        for (var i = 0; i < tracks.length; i++) {
            var track = tracks[i];
            track.stop();
        }
        video.srcObject = null;
    }

    function Capture() {
        var canvas = document.getElementById('canvas');
        var context = canvas.getContext('2d');

        // Capture the image into canvas from Webcam streaming Video element
        context.drawImage(video, 0, 0);
       // SaveCapture();
        ShowData();
    }

    function ShowData() {
        var studentCode = $('#StudentCode2').val();
        var studentName = $('#StudentName').val();
        var orderNumber = $('#OrderNumber').val();
        swal({
            title: ""Chào mừng bạn "" + studentName,
            text: ""Mời ");
            WriteLiteral(@"bạn về máy số "" + orderNumber + "" để dự thi"",
            type: ""success"",
            showCancelButton: !1,
            confirmButtonColor: ""#DD6B55"",
            confirmButtonText: ""Mời bạn tiếp theo !"",
        }).then(function () {
            window.location.href = UrlRoot;
        });
    }

    function SaveCapture() {
        var studentCode = $('#StudentCode2').val();
        var studentName = $('#StudentName').val();
        var orderNumber = $('#OrderNumber').val();
        // Below new canvas to generate flip/mirron image from existing canvas
        var destinationCanvas = document.createElement(""canvas"");
        var destCtx = destinationCanvas.getContext('2d');


        destinationCanvas.height = 500;
        destinationCanvas.width = 500;

        destCtx.translate(video.videoWidth, 0);
        destCtx.scale(-1, 1);
        destCtx.drawImage(document.getElementById(""canvas""), 0, 0);

        // Get base64 data to send to server for upload
        var imagebase64data");
            WriteLiteral(@" = destinationCanvas.toDataURL(""image/png"");
        imagebase64data = imagebase64data.replace('data:image/png;base64,', '');
        $.ajax({
            type: 'POST',
            url: UrlRoot + 'Home/UploadWebCamImage/',
            data: { imageData: imagebase64data, code: studentCode },
            /*contentType: 'application/json; charset=utf-8',*/
            dataType: 'json',
            success: function (data) {
                if (data.response >= 0) {
                    //const random = Math.floor(Math.random() * myArray.length);
                    //console.log(random, myArray[random]);
                    swal({
                        title: ""Chào mừng bạn "" + studentName,
                        text: ""Mời bạn về máy số "" + orderNumber + "" để dự thi"",
                        type: ""success"",
                        showCancelButton: !1,
                        confirmButtonColor: ""#DD6B55"",
                        confirmButtonText: ""Mời bạn tiếp theo !"",
                  ");
            WriteLiteral(@"  }).then(function () {
                        myArray.filter(e => e !== myArray[random]);
                        window.location.href = UrlRoot;
                    });
                } else {
                    sweetAlert(""Oops..."", data.message, ""error"");
                }
            }
        });
    }
</script>
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
