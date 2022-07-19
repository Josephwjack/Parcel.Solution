using Microsoft.AspNetCore.Mvc;
using ParcelCompany.Models;
using System.Collections.Generic;

namespace ParcelCompany.Controllers
{
  public class ParcelsController : Controller
  {
    [HttpGet("/parcels")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/parcels/new")]
    public ActionResult CreateForm()
    {
      return View("parcels");
    }

    [HttpPost("/parcels")]
    public ActionResult Create(int width, int length, int height, int weight, bool international)
    {
      Parcel newParcel = new Parcel(width, length, height, weight, international);
      newParcel.CostToShip();
      return RedirectToAction("Index");
      
    }
  }
}
