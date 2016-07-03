using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockoutMvcWebApplication.Controllers
{
    public class QuoteEntryController : Controller
    {
        // GET: QuoteEntry
        public ActionResult Index()
        {
            return View();
        }
    }
}