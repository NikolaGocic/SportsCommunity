using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsCommunity.DomainModel
{
    public class Event
    {

        public int id { get; set; }

        public DateTime dateTime { get; set; } // datum odrzavanja dogadjaja

        public String name { get; set; } // naziv eventa

        public EventType eventType { get; set; } // tip eventa - relacija Event_Type

        public Location location { get; set; } //mesto odrzavanja - At_Location relacija


    }
}
