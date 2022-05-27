using Microsoft.AspNetCore.Mvc;
using Factory.Models;

namespace Factory.Controllers
{
    public class HomeController : Controller
    {    
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}