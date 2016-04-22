using QuanLyNhaXe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLyNhaXe.Controllers
{
    public class XasController : ApiController
    {
        [HttpGet]
        public IEnumerable<Xa> Get()
        {
            try
            {
                return Xa.GetAll();
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        public IEnumerable<Xa> Get(int id)
        {
            try
            {
                var ds = Xa.GetAll();
                List<Xa> lts = new List<Xa>();
                lts.Add(ds.FirstOrDefault(p => p.idxa == id));
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
