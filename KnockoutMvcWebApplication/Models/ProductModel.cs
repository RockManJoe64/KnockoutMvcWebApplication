using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutMvcWebApplication.Models
{
  public class ProductModel
  {
    public string ProductCode { get; set; }
    public string ProductName { get; set; }
    public decimal ProductPrice { get; set; }
    public int ProductQty { get; set; }
    public List<ProductOrderModel> ProductOrders { get; set; }

    public ProductModel()
    {
      ProductOrders = new List<ProductOrderModel>();
    }
  }

  public class ProductOrderModel
  {
    public string Customer { get; set; }
    public int Qty { get; set; }
    public bool Express { get; set; }
  }
}