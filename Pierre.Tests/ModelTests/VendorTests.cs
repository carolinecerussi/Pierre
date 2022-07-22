using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pierre.Models;
using System;

namespace Pierre.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    // [Testmethod]
    // public void GetVendorName_ReturnsVendorName_String()
    // {
    //   string vendorName = "test name";
    //   Vendor newVendor = new Vendor(name);
    //   string result = newVendor.Name;
    //   Assert.AreEqual(name, result);
    // }
  }
}