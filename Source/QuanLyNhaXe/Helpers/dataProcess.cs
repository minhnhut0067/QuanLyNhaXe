using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class dataProcess
    {
        private static string DefaultUrl = "http://localhost:3174/api/";
        public static string HttpPostData(string PostData)
        {
            return HttpPostData(DefaultUrl, PostData);
        }
        public static string HttpPostData(string Url, string PostData)//string v_page, string v_action
        {
            try
            {
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";//application/json
                    var data = "229";
                    var result = client.UploadString(Url + "quocgias", "POST",data);
                    return result;
                }
                //var request = (HttpWebRequest)WebRequest.Create(uri);
                ////HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create(@"http://localhost:1234/test/WebService1.asmx/savedata");
                //request.Headers.Add(@"SOAP:Action");
                //request.ContentType = "text/xml;charset=\"utf-8\"";
                //request.Accept = "text/xml";
                //request.Method = "POST";
                ////request.Method = "POST";
                ////request.ContentType = "application/x-www-form-urlencoded";
                ////request.ContentType = "application/json";
                ////var postData = v_data;
                //var data = Encoding.UTF8.GetBytes(postData);
                //request.ContentLength = data.Length;

                //using (var stream = request.GetRequestStream())
                //{
                //    stream.Write(data, 0, data.Length);
                //}
                //var responseString = "";
                //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                //if (response.StatusCode == HttpStatusCode.OK)
                //{
                //    responseString = xmltostring(new StreamReader(response.GetResponseStream()).ReadToEnd());
                //}
                //return responseString.ToString();

            }
            catch
            {
                return "";
            }
        }
    }
}
