using QuanLyNhaXe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuanLyNhaXe.Controllers
{
    public class UsersController : ApiController
    {
        [HttpGet]
        public IEnumerable<UserLogin> Get()
        {
            try
            {
                return UserLogin.GetAll();
            }
            catch
            {
                return null;
            }
        }
        [HttpGet]
        public IEnumerable<UserLogin> Get(int id)
        {
            try
            {
                var ds = UserLogin.GetAll();
                List<UserLogin> lts = new List<UserLogin>();
                lts.Add(ds.FirstOrDefault(p => p.iduser == id.ToString()));
                return lts;
            }
            catch
            {
                return null;
            }
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody]IEnumerable<UserLogin> user)
        {
            try
            {
                var ds = UserLogin.GetAll();
                List<UserLogin> lts = new List<UserLogin>();
                //lts.Add(ds.FirstOrDefault(p => p.username_ == id));
                //return lts;
            }
            catch
            {
                //return null;
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
