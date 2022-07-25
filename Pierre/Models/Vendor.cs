using System.Collections.Generic;

namespace Pierre.Models
{
  public class Vendor
  {
    public int Id {get;}
    public string VendorName{get;}
    public static List<Vendor> _instances{get;set;}
    public Vendor(string vendorName)
    {
      VendorName= vendorName;
     _instances.Add(this.VendorName);
    Id = _instances.Count;
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