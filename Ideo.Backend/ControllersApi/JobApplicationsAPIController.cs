using Ideo.Backend.DBContext;
using Ideo.Backend.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ideo.Backend.ControllersApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobApplicationsAPIController : ControllerBase
    {
        private IdeoBackendContext Context;

        // GET: api/<JobApplicationsAPIController>
        [HttpGet]
        public string Get()
        {
            var jbApps = Context.JobApplications.ToList();
            var jbAppsS = JsonSerializer.Serialize(jbApps);
            return jbAppsS;
        }

        // GET api/<JobApplicationsAPIController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            Guid ID = Guid.Parse(id);
            var jb = Context.JobApplications.Where(x => x.Id == ID).First();
            return JsonSerializer.Serialize(jb);
        }

        // POST api/<JobApplicationsAPIController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            var jb = JsonSerializer.Deserialize<JobApplication>(value);
            Context.JobApplications.Add(jb);
            Context.SaveChanges();
        }

        // PUT api/<JobApplicationsAPIController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            var jb = Context.JobApplications.Where(x => x.Id == Guid.Parse(id)).First();
            var jbd = JsonSerializer.Deserialize<JobApplication>(value);
            jb = jbd;
            Context.SaveChanges();
        }

        // DELETE api/<JobApplicationsAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var jb = Context.JobApplications.Where(x => x.Id == Guid.Parse(id)).First();
            Context.JobApplications.Remove(jb);
            Context.SaveChanges();
        }
    }
}
