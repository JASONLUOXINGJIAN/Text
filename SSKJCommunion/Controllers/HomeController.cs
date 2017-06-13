using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSKJCommunion.Models
{
    public class HomeController : Controller
    {
        // GET: Home

        public ActionResult Index()
        {
            System.Web.HttpContext.Current.Session["test"] = "123";
            return View();
        }
        public ActionResult hehe()
        {
            return View();
        }
        public ActionResult Text()
        {
            ViewBag.message = "我是一个VieBag";
            System.Web.HttpContext.Current.Session["test"] = "123";
            ViewData["name"] = "小明";


            return View();
        }
        public ActionResult DetailsTitle(string title)
        {
            var ss = title;
            if (ss != null || ss == "")
            {
                string[] sArray = ss.Split('e');
                string snuble = sArray[1];
                ViewBag.snuble = "标题名" + snuble;
                ViewBag.sb = Session["test"];
            }

            //Response.Redirect();
            return View();
        }
    }
}