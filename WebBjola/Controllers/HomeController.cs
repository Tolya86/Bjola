using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBjola.Models;

namespace WebBjola.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Test> lTest = new List<Test>();
            for (int i = 0; i < 100; i++)
            {
                lTest.Add(new Test("user-" + i.ToString()));
            }
               string ERR = "Брат....так!";
            using (BjolaBase bb = new BjolaBase())
            {
                try
                {
                    for (int i = 0; i < lTest.Count; i++)
                        bb.Add(lTest[i]);
                    bb.SaveChanges();
                }

                catch (Exception e)
                {
                    ERR = e.Message;
                }

            }



            ViewBag.data = lTest;    
            ViewBag.message = ERR;

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
