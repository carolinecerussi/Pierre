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
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "test name";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.VendorName;
      Assert.AreEqual(vendorName, result);
    }
    [TestMethod]
    public void GetAll_ReturnsVendors_Vendors_VendorList()
    {
      string vendor1 = "caroline";
      string vendor2 = "finn";
      Vendor newVendor1 = new Vendor(vendor1);
      Vendor newVendor2 = new Vendor(vendor2);
      List<Vendor> newList = new List<Vendor>{newVendor1, newVendor2};
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderDetails()
    {
      string orderDetails = "gdffgjegm";
      Order newOrder = new Vendor(orderDetails);
      string result = newOrder.OrderDetails;
      Assert.AreEqual(orderDetails, result);
    }
    [TestMethod]
    public void GetId_ReturnVendorId_Int()
    {
      string vendorName = "text name";
      Vendor newVendor = new Vendor(vendorName);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
  }
}