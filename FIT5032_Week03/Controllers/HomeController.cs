using FIT5032_Week03.Exercise;
using FIT5032_Week03.HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIT5032_Week03.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // 这是个about function. 在网页里有体现。  先运行about里的
        public ActionResult About()
        {
            Hello hello = new HelloWorld.Hello();

            //通过get method来调用这个class的内容
            ViewBag.Message = hello.GetHello();


           
            ExampleDictionary ed = new ExampleDictionary();

            //作用是 debug。确认上面的code没问题  因为code是从上到下run的
            ed.Example();



            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}