using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    public static List<Vendor> _instances = new List<Vendor>{};
    public string Name { get; set;}
    public string Description { get; set; }
    public string Location { get; set;}
    public int Id { get; }
    public Vendor(string name, string description, string location)
    {
      Name = name;
      Description = description;
      Location = location;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}
