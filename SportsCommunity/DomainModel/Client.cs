using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsCommunity.DomainModel
{
    public class Client
    {
        
        public int id { get; set; }

        public String name { get; set; }

        public String username { get; set; }

        public String password { get; set; }

        public List<Client> friend_list { get; set; } // sve Friend relacije

        public List<Event> event_list { get; set; } // sve At_event relacije


    }
}
