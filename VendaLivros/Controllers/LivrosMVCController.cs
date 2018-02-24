using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VendaLivros.Controllers
{
    public class LivrosMVCController : Controller
    {
        // GET: LivrosMVC
        public ActionResult Index()
        {
            return View();
        }
    }
}