using System.Collections.Generic;
using Pierre.Models;

namespace Pierre.Models
{
  public class Order
  {
    public string OrderName { get;set;}
    public string OrderDescription{get;set;}
    public string OrderPrice {get;set;}
    public string OrderDate {get;set;}
    public int Oid{get;}
    private static List<Order> _instances = new List<Order> {};
    public Order(string orderName, string orderDescription, string orderPrice, string orderDate)
    {
      OrderName = orderName;
      OrderDescription = orderDescription;
      OrderPrice = orderPrice;
      OrderDate = orderDate;
      _instances.Add(this);
      Oid = _instances.Count;
    }    
    public static List<Order> GetAll()
    {
     return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static Order Find(int searchOid)
    {
      return _instances[searchOid-1];
    }

  }
}