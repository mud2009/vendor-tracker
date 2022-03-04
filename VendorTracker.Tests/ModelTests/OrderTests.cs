using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorTracker.Models;
using System.Collections.Generic;
using System;

namespace VendorTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    string title;
    string description;
    int price;
    string date;
    string title2;
    string description2;
    int price2;
    string date2;
    public void Dispose()
    {
      Order.ClearAll();
    }
    [TestInitialize]
    public void Initialize()
    {
      title = "title";
      description = "description";
      price = 5;
      date = "date";
      title2 = "title";
      description2 = "description";
      price2 = 5;
      date2 = "date";

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
    [TestMethod]
    public void OrderConstructor_SetsName_String()
    {
      Order newOrder = new Order(title, description, price, date);
      string updatedTitle = "title2"; 
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle ,result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrderList_OrderList()
    {
      Order newOrder = new Order(title, description, price, date);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      List<Order> orderList = new List<Order> { newOrder, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(orderList, result);
    }
    [TestMethod]
    public void Find_ReturnsOrder_Order()
    {
      Order newOrder = new Order(title, description, price, date);
      Order newOrder2 = new Order(title2, description2, price2, date2);
      Order result = Order.Find(2);
      Assert.AreEqual(newOrder2, result);
    }
  }
}