using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrossroadsPrototype.Models
{
    [Table(name: "Venues")]
    public class Venue
    {
        public int VenueID { get; set; }

        public string VenueName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZIP { get; set; }
    }
}
