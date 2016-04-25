using QuanLyNhaXe.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLyNhaXe.Controllers
{
    public class QuocgiasController : ApiController
    {
        [HttpGet]
        public IEnumerable<QuocGia> Get()
        {
            try
            {
                return QuocGia.GetAll();
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        public IEnumerable<QuocGia> Get(int id)
        {
            try
            {
                var ds = QuocGia.GetAll();
                List<QuocGia> lts = new List<QuocGia>();
                lts.Add(ds.FirstOrDefault(p => p.idquocgia == id));
                return lts;
            }
            catch
            {
                return null;
            }
        }
        // POST api/values
        [HttpPost]
        public IEnumerable<QuocGia> Post([FromBody]int id)
        {
            try
            {
                var ds = QuocGia.GetAll();
                List<QuocGia> lts = new List<QuocGia>();
                lts.Add(ds.FirstOrDefault(p => p.idquocgia == id));
                return lts;
            }
            catch
            {
                return null;
            }
        }
        [HttpPut]
        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }
        [HttpDelete]
        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
