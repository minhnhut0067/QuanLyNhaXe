using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLyNhaXe.Models
{
    public class Tinh
    {
        public int idtt { get; set; }
        public string ten { get; set; }
        public static IEnumerable<Tinh> GetAll()
        {
            try
            {
                DataSet ds = new DataSet();
                List<Tinh> lts = new List<Tinh>();
                string sql = "select idtt,ten from dmtt";
                ds = Helpers.dbProcess.getDataSetbySql(sql);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Tinh item = new Tinh();
                        item.idtt = Int32.Parse(dr["idtt"].ToString());
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