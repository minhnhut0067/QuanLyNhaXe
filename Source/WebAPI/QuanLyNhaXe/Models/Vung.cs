using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLyNhaXe.Models
{
    public class Vung
    {
        public int idvung { get; set; }
        public string ma { get; set; }
        public string ten { get; set; }
        public static IEnumerable<Vung> GetAll()
        {
            try
            {
                DataSet ds = new DataSet();
                List<Vung> lts = new List<Vung>();
                string sql = "select idvung,ma,ten from dmvung";
                ds = Helpers.dbProcess.getDataSetbySql(sql);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        Vung item = new Vung();
                        item.idvung = Int32.Parse(dr["idvung"].ToString());
                        item.ma = dr["ma"].ToString();
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