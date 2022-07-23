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
    public ActionResult Create(string orderName)
    {
      Order theOrder = new Order(orderName);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendor/{id}/order/{oid}")]
    public ActionResult Show(int oid)
    {
      Order foundOrder = Order.Find(oid);
      return View(foundOrder);
    }
    [HttpGet("/vendor/{id}/order/{Oid}new")]
    public ActionResult New()
    {
      return View();
    }
  }
}