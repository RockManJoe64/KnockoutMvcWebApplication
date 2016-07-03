using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockoutMvcWebApplication.Models;
using KnockoutMvcWebApplication.ModelBinder;

namespace KnockoutMvcWebApplication.Controllers
{
  public class ProductController : Controller
  {
    // GET: Product
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult SaveProduct([FromJson] ProductModel product)
    {
      return View("Index");
    }
  }
}