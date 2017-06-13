using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Web;
using System.Web.Mvc;

namespace SSKJCommunion.Controllers
{
    public class TextController : Controller
    {
        // GET: Text
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TextUPimage()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SavePicture(string picString)
        {
            HttpPostedFileBase ss = Request.Files["picAjax"];
            bool isOk = false;
            string msg = string.Empty;
            //Base64StringToImage(picString);
            //其他操作
            //.........
            //.........
            return Json(new { suc = isOk, msg = msg });
        }
        //base64编码的文本 转为    图片

        public ActionResult UPPicture(HttpPostedFileBase file)
        {
            HttpPostedFileBase ss = Request.Files["file"];

            bool isOk = false;
            string FileName = ss.FileName;
            string msg = string.Empty;
            string guid = "";

            string src = "";
            if (FileName != "" && FileName != null)
            {
                string FileType = FileName.Substring(FileName.LastIndexOf(".") + 1); //得到文件的后缀名  
                //guid = System.Guid.NewGuid().ToString() + "." + FileType; //得到重命名的文件名  
                guid = DateTime.Now.ToString("yyyymmddhhmmss") + "." + FileType;
                ss.SaveAs(Server.MapPath("/Upload/") + guid); //保存操作  
                src = Server.MapPath("/Upload/") + guid;

            }
            //return Content("<div>其他内容</div><Script>alert(111)</Script>");
            return Content("<Script>alert('成功');</Script>");

        }
    }
}