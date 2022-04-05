using ChillhopStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Data.Models;

namespace WebAPI.Interface
{
    public interface IProductRepository
    {
      List<Product> GetProducts();
      Product GetProduct(int id);
    }
}
