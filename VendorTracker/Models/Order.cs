using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Order
  {
    public string Title { get; }
    string Description { get; }
    int Price { get; }
    string Date { get; }
    public Order( string title, string description, int price, string date)
    {
      Title = title;
      Description = description;
      Price = price;
      Date = date;
    }
  }
}