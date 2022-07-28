using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pierre.Models;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class OrderTests: IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetOrderName_ReturnsName_String()
    {
      string orderName = "carolines order";
      Order newName = new Order(orderName);
      string result = newOrder.OrderName;
      Assert.AreEqual(orderName, result);
    }
    [TestMethod]
    public void GetOrderDescription_ReturnsDescription_String()
    {
      string orderDescription = "watermelons";
      Order newDescription = new Order(orderDescription);
      string result = newDescription.OrderDescription;
      Assert.AreEqual(orderDescription, result);
    }
    [TestMethod]
    public void GetOrderPrice_ReturnsPrice_String()
    {
      string orderPrice = "12";
      Order newPrice = new Order(orderPrice);
      string result = newPrice.OrderPrice;
      Assert.AreEqual(orderPrice, result);
    }
    [TestMethod]
    public void GetOrderDate_ReturnsDate_String()
    {
      string orderDate = "11/22/1994";
      Order newDate = new Order(orderDate);
      string result = newDate.OrderDate;
      Assert.AreEqual(orderName, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrderObjects_NewOrder()
    {
      string OrderName = "caroline";
      string OrderDescription = "goggles";
      string OrderPrice = "12";
      string OrderDate = "11/22/2022";
      Order newOrder = new Order{orderName, orderDescription, orderPrice, orderDate};
      result = order.NewOrder;
      // List<Order> newList = new List<Order>{newVendor, newVendor2};
      CollectionAssert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyOrderList_OrderList()
    {
      List<Order> newList = new List<Order>{};
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_ReturnOrderId_Int()
    {
      string orderInfo = "text info";
      Order newOrder = new Order(orderInfo);
      int result = newOrder.Oid;
      Assert.AreEqual(1, result);
    }
  }
}