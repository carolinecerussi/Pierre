using System.Collections.Generic;

namespace Pierre.Models
{
  public class Vendor
  {
    public string VendorName {get;set;}
    public int Id {get;}
    private static List<Vendor> _instances = new List<Vendor>{};
    public Vendor(string vendorName)
    {
      VendorName =vendorName;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}