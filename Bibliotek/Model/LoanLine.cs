using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class LoanLine
    {
        public int Id { get; set; }
        public Book Book { get; set; }
        public Loaner Loaner { get; set; }
    }
}
