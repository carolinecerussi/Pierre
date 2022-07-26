using System.Collections.Generic;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc;


namespace Pierre.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/vendor/{id}/order/new")]
    public ActionResult New(int id)
    {
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
    }
    [HttpGet("/vendor/{id}/order/{oid}")]
    public ActionResult Show(int id, int oid)
    {
      Order order = Order.Find(oid);
      Vendor vendor = Vendor.Find(id);
      Dictionary<string, object> model= new Dictionary<string,object>();
      model.Add("order",order);
      model.Add("vendor", vendor);
      return View(model);
    }
    // [HttpGet("/vendor/{id}/order/{oid}")]
    // public ActionResult Show(string orderDetails)
    // {
    //   Order orderDetails = new Order(orderDetails);
    //   return View(orderDetails);
    
  }
}