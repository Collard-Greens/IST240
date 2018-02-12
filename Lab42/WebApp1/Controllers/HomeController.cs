using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Phartze Inc: Everyone should just leave.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "You are not allowed to contact me.";

            return View();
        }

        public ActionResult CalcApp(string valA, string valB, string Op)
        {

            
                int number1 = Convert.ToInt32(valA);
                int number2 = Convert.ToInt32(valB);
                int StringAnswer = 0;
                string calc = (Request["calc"]);

                switch (calc)
                {
                    case "add":
                        StringAnswer = number1 + number2;
                        break;
                    case "multiply":
                        StringAnswer = number1 * number2;
                        break;
                    case "divide":
                        StringAnswer = number1 / number2;
                        break;
                    case "subtract":
                        StringAnswer = number1 - number2;
                        break;
                }
            return View("CalcApp", (object)StringAnswer);


        }
    }
}