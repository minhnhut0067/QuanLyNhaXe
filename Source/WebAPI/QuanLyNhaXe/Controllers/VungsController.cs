using QuanLyNhaXe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLyNhaXe.Controllers
{
    public class VungsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Vung> Get()
        {
            try
            {
                return Vung.GetAll();
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        public IEnumerable<Vung> Get(int id)
        {
            try
            {
                var ds = Vung.GetAll();
                List<Vung> lts = new List<Vung>();
                lts.Add(ds.FirstOrDefault(p => p.idvung == id));
                return lts;
            }
            catch
            {
                return null;
            }
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
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
