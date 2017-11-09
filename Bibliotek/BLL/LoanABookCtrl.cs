using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoanABookCtrl
    {
        DALContext ctx = new DALContext();

        public void MakeLoan(Loaner loaner, Book book)
        {
            var loanLine = new LoanLine { Loaner = loaner, Book = book };
            loaner.LoanedBooks.Add(loanLine);

            ctx.LoanLines.Add(loanLine);
            ctx.SaveChanges();
        }
    }
}
