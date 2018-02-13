using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Entities
{
    public class Players: EntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public virtual Team Team{ get; set; }

    }
}