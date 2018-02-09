using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Entities
{
    public class Team: EntityBase
    {
        public string Name{ get; set; }

        public virtual ICollection<Player> Players { get; set; }
    }
}