using System.Collections.Generic;
using Pierre.Models;

namespace Pierre.Models
{
  public class Order
  {
    public int Oid {get;}
    private static List<Order> _instancesO = new List<Order>{};
    public Order(string orderName, string orderDescription, string orderPrice, string orderDate)
    {
    _OrderName=orderName;
    _OrderDescription = orderDescription;
    _OrderPrice = orderPrice;
    _OrderDate= orderDate;
    _instancesO.Add(this);
    Oid = _instancesO.Count;
    }
    public static List<Order> GetAll()
    {
      return _instancesO;
    }
    public static void ClearAll()
    {
      _instancesO.Clear();
    }
    public static Order Find(int searchOid)
    {
      return _instancesO[searchOid-1];
    }

  }
}