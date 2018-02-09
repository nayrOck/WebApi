using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CatController : ApiController
    {
        private List<string> _cats = new List<string> { "John", "Paul", "George" };

        public List<string> Get()
        {
            return _cats;
        }

        public string Get(int id)
        {
            return _cats.Count > id ? _cats[id]: null;
        }
    }
}
