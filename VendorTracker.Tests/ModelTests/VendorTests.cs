using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    string name;
    string description;
    string location;
    [TestInitialize]
    public void Initialize()
    {
      name = "bread store";
      description = "place to buy bread";
      location = "over there";
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor(name, description, location);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void VendorConstructor_ReturnsName_String()
    {
      Vendor newVendor = new Vendor(name, description, location);
      string result = newVendor.Name;
      Assert.AreEqual(result, name);
    }
    [TestMethod]
    public void VendorConstructor_SetsName_String()
    {
      Vendor newVendor = new Vendor(name, description, location);
      string updatedTest = "not bread store";
      newVendor.Name = updatedTest;
      string result = newVendor.Name;
      Assert.AreEqual(result, updatedTest);
    }
  }
}