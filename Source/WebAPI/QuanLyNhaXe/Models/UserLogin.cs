using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLyNhaXe.Models
{
    public class UserLogin
    {
        public string iduser { get; set; }
        public string username_ { get; set; }
        public string password_ { get; set; }
        public string hoten { get; set; }
        public string ngaysinh { get; set; }
        public static IEnumerable<UserLogin> GetAll()
        {
            try
            {
                DataSet ds = new DataSet();
                List<UserLogin> lts = new List<UserLogin>();
                string sql = "select iduser,username_,password_,hoten,ngaysinh from users";
                ds = Helpers.dbProcess.getDataSetbySql(sql);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        UserLogin item = new UserLogin();
                        item.iduser = dr["iduser"].ToString();
                        item.username_ = dr["username_"].ToString();
                        item.password_ = dr["password_"].ToString();
                        item.hoten = dr["hoten"].ToString();
                        item.ngaysinh = dr["ngaysinh"].ToString();
                        lts.Add(item);
                    }
                }
                return lts;
            }
            catch
            {
                return null;
            }
        }
    }
}