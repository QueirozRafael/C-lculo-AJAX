using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CalculoAJAX.Controllers
{
    public class AJAXController : Controller
    {
        // GET: AJAX
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult JsonFatorial(int n)
        {
            return new JsonResult
            {
                Data = new { Fatorial = Fatorial(n) }
            };
        }

        private object Fatorial(int n)
        {
            var numero = (n == 0 ? 0 : n);

            for (int i = 2; i < n; i++)
            {
                numero *= i;
            }

            return numero;
        }
    }
}