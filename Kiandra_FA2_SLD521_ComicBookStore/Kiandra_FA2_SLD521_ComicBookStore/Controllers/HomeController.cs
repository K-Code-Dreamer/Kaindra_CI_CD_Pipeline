using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kiandra_FA2_SLD521_ComicBookStore.Controllers
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

        public ActionResult Location()
        {
            ViewBag.Message = "Your Location page.";

            return View();
        }

        public ActionResult Favourites()
        {
            ViewBag.Message = "Your Favourites page.";

            return View();
        }

        public ActionResult LatestNews()
        {
            ViewBag.Message = "Your Latest News page.";

            return Redirect("https://www.denofgeek.com/comics/");
        }
    }
}