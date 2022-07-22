using System.Collections.Generic;
using System;
using Pierre.Models;
using Microsoft.AspNetCore.Mvc;


namespace Pierre.Controllers
{
  public class OrderController : Controller
  {
    [HttpGet("/vendor/{id}/order/")]
    public ActionResult Index()
    {
      List<Order> allOrders = Order.GetAll();
      return View(allOrders);
    }
    [HttpPost("/vendor/{id}/order")]
    public ActionResult Create(string orderInfo)
    {
      Order theOrder = new Order(orderInfo);
      return RedirectToAction("View");
    }
    [HttpGet("/vendor/{id}/order/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("/vendor/{id}/order/{oid}")]
    public ActionResult Show(int oid)
    {
    Order foundOrder = Order.Find(oid);
    return View(foundOrder);
    }
  }
}