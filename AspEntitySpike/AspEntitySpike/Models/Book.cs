using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspEntitySpike.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public List<Loan> Loans { get; set; }
    }
}