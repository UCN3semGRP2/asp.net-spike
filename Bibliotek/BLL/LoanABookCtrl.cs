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

        public void MakeLoan(int loanerId, int bookId)
        {
            var loaner = ctx.Loaners.Find(loanerId);
            var book = ctx.Books.Find(bookId);
            var loanLine = new LoanLine { Loaner = loaner, Book = book };
            loaner.LoanedBooks.Add(loanLine);

            ctx.LoanLines.Add(loanLine);
            ctx.SaveChanges();
        }

        public List<Book> AllBooksInStock()
        {
            return new BookCtrl().AllBooksInStock();
        }

        public List<Loaner> AllLoaners()
        {
            return new LoanerCtrl().AllLoaners();
        }
    }
}
