using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AngularjsApp.Controllers
{
    public class HomeController : Controller
    {
        public class İletisim
        {
            public string Adiniz { get; set; }
            public string EPosta { get; set; }
            public string Mesaj { get; set; }
            public string Konu { get; set; }


        }


        public ActionResult TodoList()
        {
            return View();
        }


        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Send()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Send(İletisim model)
        {

            if (ModelState.IsValid)
            {

            }

            var errors = ModelState.Select(x => x.Value).ToList();

            return Json(model);
        }

    }
}