using System.Collections.Generic;
using System;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc;


namespace Pierre.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult IndexV()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendor")]
    public ActionResult Create(string vendorName)
    {
    Vendor newVendor = new Vendor(vendorName);
    return RedirectToAction("IndexV");
    }
    [HttpGet("/vendor/{id}")]
    public ActionResult Show(int id)
    {
      Vendor neededVendor = new Vendor(id); 
      return Show(neededVendor);
    }
  }

  }
