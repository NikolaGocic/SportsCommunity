using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsCommunity.DomainModel
{
    public class Location
    {
        public int id { get; set; }

        public String address { get; set; }

        public City city { get; set; }  //grad u kome je event trenutno u bazi postoje samo 3 grada: Nis,NoviSad i Beograd


    }
}
