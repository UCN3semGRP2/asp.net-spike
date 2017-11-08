using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspEntitySpike.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string City { get; set; }
        public List<Book> Books { get; set; }

    }
}