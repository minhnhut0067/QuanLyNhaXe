using QuanLyNhaXe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLyNhaXe.Controllers
{
    public class TinhsController : ApiController
    {
        [HttpGet]
        public IEnumerable<Tinh> Get()
        {
            try
            {
                return Tinh.GetAll();
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        public IEnumerable<Tinh> Get(int id)
        {
            try
            {
                var ds = Tinh.GetAll();
                List<Tinh> lts = new List<Tinh>();
                lts.Add(ds.FirstOrDefault(p => p.idtt == id));
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
