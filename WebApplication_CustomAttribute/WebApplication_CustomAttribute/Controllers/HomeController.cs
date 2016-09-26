using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_CustomAttribute.Models;

namespace WebApplication_CustomAttribute.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Example()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Example(ExampleModel exModel)
        {
            if (ModelState.IsValid == false)
            {
                return View(exModel);
            }
            else
            {
                return Content(@"
<script>
    alert('成功 !!');
</script>");
            }
        }
    }
}