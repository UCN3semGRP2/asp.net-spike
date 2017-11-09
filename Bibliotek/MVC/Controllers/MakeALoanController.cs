using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class MakeALoanController : Controller
    {
        LoanABookCtrl ctrl = new LoanABookCtrl();
        // GET: MakeALoan
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChooseLoaner()
        {
            var loaners = ctrl.AllLoaners();
            return View(loaners);
        }

        public ActionResult ChooseBook(int? LoanerId)
        {
            //int? loanerId = Id;
            if (LoanerId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var books = ctrl.AllBooksInStock();
            var model = new Tuple<IEnumerable<Book>, int>(books, LoanerId.Value);
            return View(model);
        }
        
    }
}