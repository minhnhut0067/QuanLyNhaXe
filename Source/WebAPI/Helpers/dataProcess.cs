using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Helpers
{
    public class dataProcess
    {
        public static string ConstPathFileLog = "";
        public static string GetNameFileLog()
        {
            try
            {
                string response = "";
                DateTime dt = DateTime.Now;
                response = dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + "_" + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString() + dt.Millisecond.ToString();
                return response;
            }
            catch
            {
                return "";
            }
        }
        public static string RemoveDigits(string key)
        {
            try
            {
                return Regex.Replace(key, @"\d", "");
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string Base64Encode(string plainText)
        {
            try
            {
                var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
                return System.Convert.ToBase64String(plainTextBytes);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string Base64Decode(string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string SHAEncode(string value)
        {
            var hash = System.Security.Cryptography.SHA1.Create();
            var encoder = new System.Text.ASCIIEncoding();
            var combined = encoder.GetBytes(value ?? "");
            return BitConverter.ToString(hash.ComputeHash(combined)).ToLower().Replace("-", "");
        }
    }
}
