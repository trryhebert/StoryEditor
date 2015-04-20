using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StoryEditor.Controllers
{
    public class EditorController : Controller
    {
        //
        // GET: /Editor/

        public ActionResult Index()
        {
            string returnURL = "/";
            if (Request.Params["returnurl"] != null)
                returnURL = Request.Params["returnurl"];
            ViewBag.ReturnURL = returnURL;
            return View();
        }
        public ActionResult Save()
        {
            //todo: add save code here
            return RedirectToAction("");
        }
        public ActionResult Return()
        {
            return View();
        }

    }
}
