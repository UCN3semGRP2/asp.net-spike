using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoanerCtrl
    {
        DAL.DALContext ctx = new DAL.DALContext();

        public List<Loaner> AllLoaners()
        {
            return ctx.Loaners.ToList();
        }
    }

}
