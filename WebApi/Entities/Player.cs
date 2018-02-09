using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Entities
{
    public class Player
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }


        public virtual Team Team{ get; set; }

    }
}