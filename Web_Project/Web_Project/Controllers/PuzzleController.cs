using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web_Project.Controllers
{
    public class PuzzleController : Controller
    {
        // GET: Puzzle
        public ActionResult Level1()
        {
            ViewBag.Message = " - Hit.請輸入答案";
            return View();
        }
        public ActionResult Level2()
        {
            ViewBag.Message = " - Hit. print(\"1\" + \"1\")";
            return View();
        }
        public ActionResult Level3()
        {
            return View();
        }
        public ActionResult Level4()
        {
            return View();
        }
        public ActionResult Level5()
        {
            return View();
        }
        public ActionResult Level6()
        {
            return View();
        }
        public ActionResult Level7()
        {
            return View();
        }
        public ActionResult Level8()
        {
            return View();
        }
    }
}