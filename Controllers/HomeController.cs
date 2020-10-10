using Microsoft.AspNetCore.Mvc;

namespace AS_Portfolio_1.Controllers 
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        
        public ViewResult Index ()
        {
            return View();
        }

        [HttpGet("projects")]
        public ViewResult Projects ()
        {
            return View();
        }

        
        [HttpGet("contacts")]
        public ViewResult Contacts ()
        {
            return View();
        }

    }
}