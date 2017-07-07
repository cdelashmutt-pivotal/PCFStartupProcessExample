using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.IO;
using SampleSite.Models;

namespace SampleSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var serializer = new JsonSerializer();
            using (var recentChangeStream = new JsonTextReader(new StreamReader(new FileStream(Server.MapPath("/recentUpdates.json"), FileMode.Open))))
            {
                ViewBag.Data = serializer.Deserialize<ChangeQueryResponse>(recentChangeStream);
            }
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
    }
}