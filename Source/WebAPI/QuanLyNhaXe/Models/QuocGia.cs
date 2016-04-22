using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace QuanLyNhaXe.Models
{
    public class QuocGia
    {
        public int idquocgia { get; set; }
        public string iso { get; set; }
        public string ten { get; set; }
        public static IEnumerable<QuocGia> GetAll()
        {
            try
            {
                DataSet ds = new DataSet();
                List<QuocGia> lts = new List<QuocGia>();
                string sql = "select idquocgia,iso,ten from dmquocgia";
                ds = Helpers.dbProcess.getDataSetbySql(sql);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        QuocGia item = new QuocGia();                        
                        item.idquocgia = Int32.Parse(dr["idquocgia"].ToString());
                        item.iso = dr["iso"].ToString();
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