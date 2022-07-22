using System.Collections.Generic;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc;


namespace Pierre.Controllers
{
  public class VendorController : Controller
  {
    [HttpGet("/vendor")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/vendor/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}