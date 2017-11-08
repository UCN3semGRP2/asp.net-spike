using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Book
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Titel { get; set; }
        public int stock { get; set; }
    }
}
