using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsCommunity.DomainModel
{
    public class EventType
    {

        public int id { get; set; }

        public String name { get; set; }

        public String context { get; set; }  //kratak opis o tome kakva je aktivnost u pitanju

    }
}
