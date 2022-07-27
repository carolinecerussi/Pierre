using System.Collections.Generic;
using System;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc.Web;


namespace Pierre.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }
      [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName)
    {
    Vendor newVendor = new Vendor(vendorName);
    return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string,object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create(int id, string orderName,string orderDescription, string orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string,object>();
      Vendor foundVendor = Vendor.Find(id);
      Order newOrder = new Order((itemName),(itemDescription),(itemPrice),(itemDate),);
      //figure out how to call that^
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders  = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendor", foundVendor);
      return View("Show",model);
    }
  }
}
