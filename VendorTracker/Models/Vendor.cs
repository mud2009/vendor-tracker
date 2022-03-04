using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public string Name { get; set;}
    public string Description { get; set; }
    public string Location { get; set;}
    public Vendor(string name, string description, string location)
    {
      Name = name;
      Description = description;
      Location = location;
    }
  }
}
