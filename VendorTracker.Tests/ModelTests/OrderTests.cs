using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    string title;
    string description;
    int price;
    string date;
    [TestInitialize]
    public void Initialize()
    {
      title = "title";
      description = "description";
      price = 5;
      date = "date";
    }
    [TestMethod]
    public void OrderConstructor_CreatesOrderObject_Order()
    {
      Order newOrder = new Order(title, description, price, date);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void OrderConstructor_ReturnsName_String()
    {
      Order newOrder = new Order(title, description, price, date);
      string result = newOrder.Title; 
      Assert.AreEqual(title ,result);
    }
  }
}