using QuanLyNhaXe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLyNhaXe.Controllers
{
    public class QuansController : ApiController
    {
        [HttpGet]
        public IEnumerable<Quan> Get()
        {
            try
            {
                return Quan.GetAll();
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        public IEnumerable<Quan> Get(int id)
        {
            try
            {
                var ds = Quan.GetAll();
                List<Quan> lts = new List<Quan>();
                lts.Add(ds.FirstOrDefault(p => p.idquan == id));
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
