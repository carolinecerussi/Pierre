using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pierre.Models;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class VendorTests: IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      int id = 1;
      Vendor newVendor = new Vendor(id);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    // use same method above to get vendor name//
    [TestMethod]
    public void GetAll_ReturnsVendorObjects_VendorList_VendorList()
    {
      string vendorName = "caroline";
      string vendorName2 = "finn";
      Vendor newVendor = new Vendor(vendorName);
      Vendor newVendor2 = new Vendor(vendorName2);
      List<Vendor> newList = new List<Vendor>{newVendor, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string vendor1 = "caroline";
      string vendor2 = "kyle";
      Vendor newVendor1 = new Vendor(vendor1);
      Vendor newVendor2 = new Vendor(vendor2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderName = "Order 1";
      string orderDescription ="watermelons";
      string orderPrice = "23";
      string orderDate = "11/22/2022";
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDate);
      List<Order> newList = new List<Order>{newOrder};
      string vendorName ="Caroline";
      Vendor newVendor = new Vendor(vendorName);
      newVendor.AddOrder(newOrder);

      List<Order> result = newVendor.Orders;
      
      CollectionAssert.AreEqual(newList, result);
    }
  }
}