using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrossroadsPrototype.Models
{
    [Table(name:"Users")]
    public class User
    {
        public int UserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string MiddleName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int ZIP { get; set; }
    }
}
