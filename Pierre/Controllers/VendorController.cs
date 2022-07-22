using System.Collections.Generic;
using System;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc;


namespace Pierre.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName)
    {
      Vendor theVendor = new Vendor(vendorName);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Vendor foundVendor = Vendor.Find(id);
      return View(foundVendor);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}