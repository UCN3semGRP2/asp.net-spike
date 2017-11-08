using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Library
    {
        public int Id { get; set; }
        public string City { get; set; }
        public List<Book> Books { get; set; }

    }
}
