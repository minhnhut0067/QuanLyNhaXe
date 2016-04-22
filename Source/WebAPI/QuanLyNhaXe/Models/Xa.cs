using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace QuanLyNhaXe.Models
{
    public class Xa
    {
        public int idxa { get; set; }
        public string ten { get; set; }
        public string timnhanh { get; set; }
        public static IEnumerable<Xa> GetAll()
        {
            int idxa = 0;
            try
            {
                DataSet ds = new DataSet();
                List<Xa> lts = new List<Xa>();
                string sql = "select idxa,ten,timnhanh from dmxa";
                ds = Helpers.dbProcess.getDataSetbySql(sql);
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        idxa = Int32.Parse(dr["idxa"].ToString());
                        Xa item = new Xa();
                        item.idxa = Int32.Parse(dr["idxa"].ToString());
                        item.ten = dr["ten"].ToString();
                        item.timnhanh = dr["timnhanh"].ToString();
                        lts.Add(item);
                    }
                }
                return lts;
            }
            catch(Exception ex)
            {
                //StringBuilder sb;
                //sb.Append(ex.Message);
                //File.AppendAllText(Helpers.dataProcess.ConstPathFileLog.ToString() + Helpers.dataProcess.GetNameFileLog + ".txt", sb.ToString());
                //sb.Clear();
                return null;
            }
        }
    }
}