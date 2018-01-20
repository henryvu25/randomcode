using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace random_proj.Controllers
{
    public class HomeController : Controller
    {
        static int count = 0;
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            Random rand = new Random();
            string code = "";
            string alphanum = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for(int i=0; i<14; i++)
            {
               code += alphanum[rand.Next(0,36)];
            }
            count++;
            ViewBag.code = code;
            ViewBag.count = count;
            return View("Index");
        }
    }
}