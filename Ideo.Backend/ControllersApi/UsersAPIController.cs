using Ideo.Backend.DBContext;
using Ideo.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Newtonsoft.Json;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ideo.Backend.ControllersApi
{
    [Route("api/users")]
    [ApiController]
    public class UserAPIController : ControllerBase
    {
        private IdeoBackendContext Context;
        // GET: api/users
        [HttpGet]
        public string Get()
        {
            var user=Context.Users.ToList();
            var userS = JsonSerializer.Serialize(user);
            return userS;
        }

        // GET api/users/{id}
        [HttpGet("{id}")]
        public string Get(string id)
        {
            return JsonSerializer.Serialize(Context.Users.Where(x=>x.Id==id).First());
        }

        // POST api/users
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var context = Context.Users;
            var user =  JsonSerializer.Deserialize<User>(value);
            context.Add(user);
            Context.SaveChanges();

        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            var context = Context.Users;
            var user = context.Where(x => x.Id == id).First();
            var userM = JsonSerializer.Deserialize<User>(value);
            user = userM;
            context.Add(user);
            Context.SaveChanges();
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var context = Context.Users;
            var user = context.Where(x => x.Id == id).First();
            context.Remove(user);
            Context.SaveChanges();
        }
    }
}
