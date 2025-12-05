using SomiodMiddleware.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace SomiodMiddleware.Controllers
{
    [RoutePrefix("api/somiod")]
    public class ApplicationController : ApiController
    {
        //HARDCODED DATA FOR TESTING PURPOSES
        List<Application> applications = new List<Application>()
        {
            new Application(){ Id=1, Name="App1", Created_at=DateTime.Now },
            new Application(){ Id=2, Name="App2", Created_at=DateTime.Now },
            new Application(){ Id=3, Name="App3", Created_at=DateTime.Now }
        };

        //TEST ENDPOINT TO GET ALL APPLICATIONS
        [Route("")]
        [HttpGet]
        public IHttpActionResult GetApplications()
        {
            return Ok(applications);
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult AddApplication([FromBody] Application app)
        {
            if (app == null || string.IsNullOrEmpty(app.Name))
            {
                return BadRequest("Invalid application data.");
            }
            app.Id = applications.Max(a => a.Id) + 1;
            app.Created_at = DateTime.Now;
            applications.Add(app);
            return Ok("Valid application data");
        }

    }
}

