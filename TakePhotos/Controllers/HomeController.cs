using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TakePhotos.Models;
using Utils;
using TakePhotos.Handler;
using DataAccess.Factory;
using Newtonsoft.Json;
using NLog;

namespace TakePhotos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Hey, LogInformation");
            _logger.LogDebug("Hey, LogDebug");
            _logger.LogWarning("Hey, LogWarning");
            _logger.LogError("Hey, LogError");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public IActionResult FormSearch()
        {
            return View();
        }

        public IActionResult StudentGetList(string examId)
        {
            if (string.IsNullOrEmpty(examId))
            {
                return View();
            }
            var data = AbstractDAOFactory.Instance().CreateWEBDAO().StudentGetList(examId);
            return View("StudentGetList", data);
        }

        public IActionResult StudentImagePartial(string examId)
        {
            var data = AbstractDAOFactory.Instance().CreateWEBDAO().StudentGetList(examId);
            return PartialView("StudentImagePartial", data);
        }

        public IActionResult FormTakePhotos(string studentCode)
        {
            ViewBag.StudentCode = studentCode;
            ViewBag.StudentName = "";
            ViewBag.OrderNumber = 0;
            ViewBag.ExamId = "";
            var url_data = Config.URL_API + "api/v1/students/student-code/" + studentCode;
            var res = AccessAPI.GetDataAPI(url_data);
            if (res.statusCode == 200)
            {
                var returnData = JsonConvert.DeserializeObject<PostResultInfo>(res.data);
                ViewBag.StudentName = returnData.data.user.username;
                ViewBag.OrderNumber = returnData.data.orderNumber;
                ViewBag.ExamId = returnData.data.examination.id;
            }
            return View();
        }

        public JsonResult CheckDataStudent(string studentCode)
        {
            if (string.IsNullOrEmpty(studentCode))
                return Json(new { Response = -600, message = "Bạn chưa nhập mã học viên" });

            var url_data = Config.URL_API + "api/v1/students/student-code/" + studentCode;
            var res = AccessAPI.GetDataAPI(url_data);
            if (res.statusCode == 200)
                return Json(new { Response = 1, message = "success", Data = res.data });

            return Json(new { Response = -9, message = "Mã sinh viên không đúng", Data = "" });
        }

        public JsonResult UploadWebCamImage(string imageData, string code, string examId)
        {
            string uploads = Path.Combine(Config.MEDIA_DISK + "Photos/");
            //string filename = Path.Combine(Config.MEDIA_DISK + "Photos/") + DateTime.Now.ToString().Replace("/", "-").Replace(" ", "_").Replace(":", "") + ".png";
            var fileName = "";
            if (!Directory.Exists(uploads))
                Directory.CreateDirectory(uploads);
            _logger.LogInformation("UPLOAD IMAGE ARTICLE PATH :" + uploads);
            try
            {
                fileName = DateTime.Now.ToString().Replace("/", "-").Replace(" ", "_").Replace(":", "") + ".png";
                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                {
                    //file.CopyTo(fileStream);
                    using (BinaryWriter bw = new BinaryWriter(fileStream))
                    {
                        byte[] data = Convert.FromBase64String(imageData);
                        bw.Write(data);
                        bw.Close();
                    }
                }
                var imageUrl = Config.IMAGE_URL + fileName;
                var imageDataBase64 = "data:image/png;base64," + imageData;
                var result = AbstractDAOFactory.Instance().CreateWEBDAO().InsertPhotos(imageUrl, imageDataBase64, code, examId);
                _logger.LogInformation("Update Cam Image : result = " + result);
                if (result > 0)
                    return Json(new { Response = 1, message = "success" });
                else
                    return Json(new { Response = -99, message = "Có lỗi xảy ra" });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return Json(new { Response = -99, message = "Có lỗi xảy ra", Data = "" });
            }
        }
    }
}
