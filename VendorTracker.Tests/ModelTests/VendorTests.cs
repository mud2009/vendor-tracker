using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    string test;
    [TestInitialize]
    public void Initialize()
    {
      test = "bread store";
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor();
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_ReturnsName_String()
    {
      Vendor newVendor = new Vendor(test);
      string result = newVendor.Name;
      Assert.AreEqual(result, test);
    }
  }
}