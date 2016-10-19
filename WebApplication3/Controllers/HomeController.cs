using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Controllers
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
        public ActionResult Welcome()
        {
            var a = 100;
            var sum = 0;
            for (var i = 1; i <= a; i++)
            {
                sum += i;
                ViewBag.sum = sum;
                return View();
            }

            return View();
        }
        public ActionResult newList()
        {
            string[] data = new string[] {
                "斗鱼- 每个人的直播平台提供高清、快捷、流畅的视频直播和游戏",
                "女主播忘关摄像头是故意还是偶然?斗鱼tv战旗tv熊猫TV都曾发生",
                "斗鱼主播如何盈利?现在的盈利模式改了吗? ",
                "斗鱼tv下载_斗鱼tv直播客户端_斗鱼tv直播平台官网"
            };

           
                ViewBag.data = data;
                return View();
            }

         
        
    }
}