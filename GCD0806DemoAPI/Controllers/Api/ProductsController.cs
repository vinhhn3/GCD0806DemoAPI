using GCD0806DemoAPI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GCD0806DemoAPI.Controllers.Api
{
  public class ProductsController : ApiController
  {
    List<Product> products = new List<Product>
    {
      new Product{Id = 1,Name = "Tesla Model S", Category = "Car", Price = 1234567},
      new Product{Id = 2,Name = "Honda Airblade", Category = "Motorbike", Price = 121117},
      new Product{Id = 3,Name = "iPhone 13", Category = "Phone", Price = 1000},
    };

    public IHttpActionResult GetAllProducts()
    {
      return Ok(products);
    }

    public IHttpActionResult GetProduct(int id)
    {
      var product = products.SingleOrDefault(p => p.Id == id);
      if (product == null)
      {
        return NotFound(); // code 404
      }

      return Ok(product);
    }
  }
}
