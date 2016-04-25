using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
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
        public static string HttpPostData(Object obj)
        {
            return HttpPostData(DefaultUrl, obj);
        }
        public static string HttpPostData(string Url, Object obj)//string v_page, string v_action
        {
            try
            {
                //if (key.Split('~').Length > 1)
                //{ }
                using (var client = new WebClient())
                {
                    client.Headers[HttpRequestHeader.ContentType] = "application/json";//application/x-www-form-urlencoded
                    //var value = "{\"data\":{";
                    //for (int i = 0; i < key.Split('~').Length; i++)
                    //{
                    //    if (i > 0)
                    //    {
                    //        value += ",";
                    //    }
                    //    value += "\"" + key.Split('~')[i] + "\":\"" + val.Split('~')[i] + "\"";
                    //}
                    //value += "}}";
                    string value = ConvertObjtoJson(obj);
                    var result = client.UploadString(Url + "users", "POST", value);
                    return result;
                }
            }
            catch
            {
                return "";
            }
        }

        public static string ConvertObjtoJson(Object obj)
        {
            try
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                var data = JsonConvert.SerializeObject(obj, settings);
                return data;
            }            
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        
    }
}
