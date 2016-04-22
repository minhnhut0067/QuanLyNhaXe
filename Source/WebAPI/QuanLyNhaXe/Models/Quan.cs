using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLyNhaXe.Models
{
    public class Quan
    {
        public int idquan { get; set; }
        public string ten { get; set; }
        public static IEnumerable<Quan> GetAll()
        {
            try
            {
                DataSet ds = new DataSet();
                List<Quan> lts = new List<Quan>();
                string sql = "select idquan,ten from dmquan";
                ds = Helpers.dbProcess.getDataSetbySql(sql);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Quan item = new Quan();
                        item.idquan = Int32.Parse(dr["idquan"].ToString());
                        item.ten = dr["ten"].ToString();
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