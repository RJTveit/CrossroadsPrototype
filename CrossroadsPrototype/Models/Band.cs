using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrossroadsPrototype.Models
{
    [Table(name: "Artists")]
    public class Band
    {
        public int BandID { get; set; }

        public string BandName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZIP { get; set; }
    }
}
