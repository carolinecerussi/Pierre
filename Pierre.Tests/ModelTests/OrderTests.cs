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
    public void GetOrderName_ReturnsOrderInfo_String()
    {
      string orderInfo = "nice order info";
      Order newOrder = new Order(orderInfo);
      string result = newOrder.OrderInfo;
      Assert.AreEqual(orderInfo, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_Orders_OrderList()
    {
      string order1 = "order 1";
      string order2 = "order 2";
      Order newOrder1= new Order(order1);
      Order newOrder2 = new Order(order2);
      List<Order> newList = new List<Order>{newOrder1,newOrder2};
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