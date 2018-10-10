using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace dotNetMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index(string message,int number = 1)
        {
            ViewData["Message"] = message;
            ViewData["Number"] = number;    
            return View();
        }

        public string HelloUser(string name)
        {
            // return HtmlEncoder.Default.Encode($"Hello Mr. {name}");
            // return "Hello Mr. User";
            return $"Hello Mr. {name}";
        }
    }
}