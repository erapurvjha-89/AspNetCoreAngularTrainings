using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCWebApp.Controllers
{
    public class F1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string GetMessage()///Not preferered
        {
            return "c";
        }
        public ContentResult GetContent()//preferred
        {
            return Content("<h1>welcome</h1>","text/html");
        }

        public VirtualFileResult GetProject()
        {
            return File("/Downloads/WEB-API FAQ.docx","Application/docx","d.docx");
        }

        public ViewResult Display()
        {
            return View();
        }
        public ViewResult Help()
        {
            //return View("Display");
            return View("~/Views/Home/About.cshtml");
        }
    }
   
}