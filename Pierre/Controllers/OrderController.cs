using System.Collections.Generic;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc.Web;


namespace Pierre.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New(int id)
    {
      Vendor vendor = Vendor.Find(id);
      return View(vendor);
    }
    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
    [HttpGet("/vendors/{id}/orders/{oid}")]
    public ActionResult Show(int id, int oid)
    {
      Order order = Order.Find(oid);
      Vendor vendor = Vendor.Find(id);
      Dictionary<string, object> model= new Dictionary<string,object>();
      model.Add("order", order);
      model.Add("vendor",vendor);
      return View(model);
    }
    
  }
}