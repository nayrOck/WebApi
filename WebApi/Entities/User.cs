using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Entities
{
    public class User
    {
        public int ID  { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public DateTime DateCreated { get; set; }


        public virtual Account Account { get; set; }
    }
}