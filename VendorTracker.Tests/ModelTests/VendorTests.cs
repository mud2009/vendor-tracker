using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    string name;
    string description;
    string location;
    string name2;
    string description2;
    string location2;
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestInitialize]
    public void Initialize()
    {
      name = "bread store";
      description = "place to buy bread";
      location = "over there";
      name2 = "other bread store";
      description2 = "other place to buy bread";
      location2 = "over there2";

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
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void VendorConstructor_SetsName_String()
    {
      Vendor newVendor = new Vendor(name, description, location);
      string updatedTest = "not bread store";
      newVendor.Name = updatedTest;
      string result = newVendor.Name;
      Assert.AreEqual(updatedTest, result);
    }
    [TestMethod]
    public void GetId_ReturnsId_Int()
    {
      Vendor newVendor = new Vendor(name, description, location);
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendors_VendorList()
    {
      Vendor newVendor = new Vendor(name, description, location);
      Vendor newVendor2 = new Vendor(name2, description2, location2);
      List <Vendor> vendorList = new List<Vendor> { newVendor, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(vendorList, result);
    }
    [TestMethod]
    public void Find_ReturnsVendor_Vendor()
    {
      Vendor newVendor = new Vendor(name, description, location);
      Vendor newVendor2 = new Vendor(name2, description2, location2);
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }
  }
}