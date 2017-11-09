using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookCtrl
    {
        DAL.DALContext ctx = new DAL.DALContext();

        public List<Book> AllBooksInStock()
        {
            return ctx.Books.Where(b => b.Stock > 0).ToList();
        }
    }
}
