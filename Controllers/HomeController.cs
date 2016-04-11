using BH_FileShare.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BH_FileShare.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string error)
        {
            if (error != null)
            {
                ViewBag.Error = error;
            }

            return View();
        }

        [HttpPost]
        public ActionResult Index(Download d, string type)
        {
            bool success = HomeService.SaveDownloadInformation(d);

            if (success)
            {
                if (type == "code")
                {
                    return Redirect("~/Content/Hafenrichter1.jar");
                }
                else if (type == "document")
                {
                    return Redirect("~/Content/Resume.docx");
                }
                else if (type == "image")
                {
                    return Redirect("~/Content/cat.png");
                }
            }

            return RedirectToAction("Index", new { error="ValidationError" });
        }
    }
}