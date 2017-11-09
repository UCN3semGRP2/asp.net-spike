using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
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
        
    }
}