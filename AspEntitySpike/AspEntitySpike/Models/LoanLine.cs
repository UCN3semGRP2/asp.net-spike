using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspEntitySpike.Models
{
    public class LoanLine
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Loaner Loaner { get; set; }
    }
}