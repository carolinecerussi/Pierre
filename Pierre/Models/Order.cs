using System.Collections.Generic;

namespace Pierre.Models
{
  public class Order
  {
    public string OrderName {get;set;}
    public int Oid {get;}
    private static List<Order> _instances = new List<Order>{};
    public Order(string orderInfo)
    {
      OrderName =orderInfo;
      _instances.Add(this);
      Oid = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Order Find(int searchOid)
    {
      return _instances[searchOid-1];
    }

  }
}