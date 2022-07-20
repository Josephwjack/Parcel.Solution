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
      List<Parcel> allParcels = Parcel.GetAll();
      return View(allParcels);
    }

    [HttpGet("/parcels/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/parcels")]
    public ActionResult Create(string description, int width, int length, int height, int weight, bool international, int finalCost)
    {
      Parcel newParcel = new Parcel(description, width, length, height, weight, international, finalCost);
      newParcel.CostToShip();
      return RedirectToAction("Index");
      
    }

    [HttpGet("/parcels/{id}")]
    public ActionResult Show(int id)
    {
      Parcel foundParcel = Parcel.Find(id);
      return View(foundParcel);
    }


  }
}
