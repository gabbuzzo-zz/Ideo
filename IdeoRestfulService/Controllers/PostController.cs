using IdeoRestfulService.Context;
using IdeoRestfulService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace IdeoRestfulService.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        // GET: api/<PostController>
        [HttpGet]
        public IEnumerable<Post> Get()
        {
            return context.Posts.ToList();
        }

        // GET api/<PostController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PostController>
        [HttpPost]
        public async void Post ([FromBody]Post value)
        {
            try
            {
                if (value == null)
                    Debug.WriteLine(value + "Vuoto");
                    //return BadRequest("");
                context.Posts.Add(value);
               await context.SaveChangesAsync();
                //return CreatedAtAction(nameof(GetEmployee),
                    //new { id = createdEmployee.EmployeeId }, createdEmployee);
            }
            catch (Exception ex)
            {
                Debug.WriteLine( StatusCodes.Status500InternalServerError.ToString()+
                    "Error creating new employee record/"+ex.Message);
            }
            //return BadRequest("NON OK");
        }

        // PUT api/<PostController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
