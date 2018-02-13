using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Entities
{
    public class GameEvent: EntityBase
    {
        public virtual Game Game { get; set; }

        public virtual Players Player { get; set; }

        public int PointValue { get; set; }
    }
}