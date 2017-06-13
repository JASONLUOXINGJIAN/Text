using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSKJCommunion.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public static string loginname;
        public static string loginpwd;
        //登录
        [HttpPost]
        public ActionResult LoginCheck(string loginname,string loginpwd)
        {
            var p = loginname;
            //if (loginname=="visitor"&& loginpwd=="654321")
            if (loginname != "" && loginpwd != "")
            {
                
                Session["loginname"] = loginname;
                Session["loginpwd"] = loginpwd;

                loginname = Session["loginname"].ToString();
                loginpwd = Session["loginpwd"].ToString();


            }
            else {
                
            }
           

            return View();
        }
        //用户注册
        public ActionResult Register() {
           
            return View();
        }
        //退出
        public void Quit()
        {
            Session["loginname"] = "";
            Session["loginpwd"] = "";
            Response.Redirect("/Home/Index");
            

        }
        /*public ActionResult Quit() {
            Session["loginname"] = "";
            Session["loginpwd"] = "";
            Response.Redirect("/Home/Index");
            return View();
            
        }*/

    }
}