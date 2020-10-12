using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceDatabase.Models
{
    public class BrokerAdress
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FullName { get { return this.Name + " " + this.Surname; } set { } }
        public string Adress { get; set; }

        public double? GeoLong { get; set; } // долгота - для карт google
        public double? GeoLat { get; set; } // широта - для карт google
        
        //public string LongLat { get; set; }
    }
}
