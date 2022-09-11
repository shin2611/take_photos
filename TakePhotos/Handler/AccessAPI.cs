using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Utils;

namespace TakePhotos.Handler
{
    public class AccessAPI
    {
        public static PostDataResult PostDataAPI(string str_url, dynamic data)
        {
            var res = new PostDataResult();
            try
            {
                var statusCode = 0;
                string resultContent;
                using (var client = new HttpClient())
                {
                    string s = JsonConvert.SerializeObject(data);
                    NLogLogger.LogInfo(string.Format("Đầu vào {0}: {1}", str_url, s));
                    var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.ACCESS_TOKEN);
                    var result = client.PostAsync(str_url, content).Result;
                    resultContent = result.Content.ReadAsStringAsync().Result;
                    statusCode = (int)result.StatusCode;

                    NLogLogger.LogInfo("PostData Output: " + statusCode + " - " + resultContent);
                }
                res.data = resultContent;
                res.statusCode = statusCode;

                return res;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
            }
            return res;
        }

        public static PostDataResult PUTDataAPI(string str_url, dynamic data)
        {
            var res = new PostDataResult();
            try
            {
                var statusCode = 0;
                string resultContent;
                using (var client = new HttpClient())
                {
                    string s = JsonConvert.SerializeObject(data);
                    NLogLogger.LogInfo(string.Format("Đầu vào {0}: {1}", str_url, s));

                    var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.ACCESS_TOKEN);

                    var result = client.PutAsync(str_url, content).Result;
                    resultContent = result.Content.ReadAsStringAsync().Result;
                    statusCode = (int)result.StatusCode;

                    NLogLogger.LogInfo("PUTDataAPI Output: " + statusCode + " - " + resultContent);
                }
                res.data = resultContent;
                res.statusCode = statusCode;

                return res;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
            }
            return res;
        }

        public static PostDataResult GetDataAPI(string str_url)
        {
            var res = new PostDataResult();
            try
            {
                var statusCode = 0;
                string resultContent;
                using (var client = new HttpClient())
                {
                    NLogLogger.LogInfo(string.Format("Đầu vào: {0} ", str_url));
                    //var content = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8, "application/json");
                    client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/json");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Config.ACCESS_TOKEN);
                    var result = client.GetAsync(str_url).Result;
                    resultContent = result.Content.ReadAsStringAsync().Result;
                    statusCode = (int)result.StatusCode;

                    NLogLogger.LogInfo("PostData Output: " + statusCode + " - " + resultContent);
                }
                res.statusCode = statusCode;
                res.data = resultContent;

                return res;
            }
            catch (Exception ex)
            {
                NLogLogger.LogInfo(ex.ToString());
                return res;
            }
        }
    }

    public class PostDataResult
    {
        public int statusCode { get; set; }
        public bool success { get; set; }
        public string description { get; set; }
        public int code { get; set; }
        public string data { get; set; }
        public string message { get; set; }
    }

    public class PostDataResult2
    {
        public int statusCode { get; set; }
        public bool success { get; set; }
        public string description { get; set; }
        public int code { get; set; }
        public ReturnData data { get; set; }
    }

    public class ReturnData
    {
        public bool success { get; set; }
        public string description { get; set; }
        public int code { get; set; }
        public string data { get; set; }
    }
    public class DataResponse
    {
        public int code { get; set; }
        public string msg { get; set; }
        public dynamic data { get; set; }
    }

}