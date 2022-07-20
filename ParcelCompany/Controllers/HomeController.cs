using Microsoft.AspNetCore.Mvc;

namespace ParcelCompany.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View("Index");
    }
  }
}