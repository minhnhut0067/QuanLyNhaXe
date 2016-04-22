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
            public string username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string password { get; set; }            

            [Display(Name = "Nhớ mật khẩu")]
            public bool RememberMe { get; set; }

            public bool IsValid(string _username, string _password)
            {
                try
                {
                    //using (NpgsqlConnection conn = new NpgsqlConnection(DefaultConnectionString))
                    //{
                    //    string _sql = @"SELECT username " +
                    //        @"FROM ms_data.tbl_users " +
                    //        @"WHERE username = @user AND password = @pass";
                    //    NpgsqlCommand cmd = new NpgsqlCommand(_sql, conn) { CommandTimeout = 7200 };
                    //    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(cmd);
                    //    cmd.Parameters.Add(new NpgsqlParameter("@user", NpgsqlDbType.Varchar)).Value = _username;
                    //    cmd.Parameters.Add(new NpgsqlParameter("@pass", NpgsqlDbType.Varchar)).Value = Helpers.SHA1.Encode(_password);
                    //    conn.Open();
                    //    NpgsqlDataReader reader = cmd.ExecuteReader();
                    //    if (reader.HasRows)
                    //    {
                    //        reader.Dispose();
                    //        cmd.Dispose();
                    //        conn.Close();
                    //        return true;
                    //    }
                    //    else
                    //    {
                    //        reader.Dispose();
                    //        cmd.Dispose();
                    //        conn.Close();
                    //        return false;
                    //    }
                    //}
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