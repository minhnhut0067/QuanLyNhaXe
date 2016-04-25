using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace www.Models
{
    public class Users
    {
        public class Login
        {
            [Required]
            [Display(Name = "Tên đăng nhập")]
            public string username_ { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string password_ { get; set; }            

            [Display(Name = "Nhớ mật khẩu")]
            public bool RememberMe { get; set; }

            public static bool IsValid(string _username, string _password)
            {
                try
                {
                    var value = Helpers.dataProcess.HttpPostData(_username, _password);
                    return true;
                }
                catch (Exception ex)
                {
                    //dbh.f_write_log("Login.IsValid() :: exe_get :: " + ex.ToString());
                    return false;
                }
            }
        }
    }
}