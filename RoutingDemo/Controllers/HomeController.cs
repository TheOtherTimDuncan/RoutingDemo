using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace RoutingDemo.Controllers
{
    [RoutePrefix(HomeController.Route)]
    public class HomeController : Controller
    {
        public const string Route = "Home";

        [Route("~/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("~/About")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Route("~/Contact")]
        public ActionResult Contact(ContactQuery query)
        {
            ViewBag.Message = $"Your contact page for {query.ContactName}.";

            return View();
        }
    }

    public class ContactQuery
    {
        public string ContactName
        {
            get;
            set;
        }
    }
}
