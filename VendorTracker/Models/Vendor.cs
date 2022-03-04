using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; }
    public Vendor(string name)
    {
      Name = name;
    }
  }
}
