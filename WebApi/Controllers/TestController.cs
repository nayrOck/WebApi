using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class TestController : ApiController
    {
        public class Sample
        {
            public int ID { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }
        }

        public IHttpActionResult Get()
        {
            var sample = new Sample { ID = 10, Description = "Test Description", Date = DateTime.Now };
            return Ok(sample);
        }

        public IHttpActionResult Post([FromUri] Sample s)
        {
            return Ok(s.ID);
        }

    }
}
