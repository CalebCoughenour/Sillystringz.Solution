using Microsoft.AspNetCore.Mvc;

namespace NamespaceOfProject.Controllers
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