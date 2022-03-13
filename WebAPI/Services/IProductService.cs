using System.Collections.Generic;
using WebAPI.Data.Models;

namespace WebAPI.Services
{
    public interface IProductService
    {
        IList<Product> GetProducts();
        Product GetProduct(int Id);
        Product CreateProduct(Product product);
        void UpdateProduct(int Id, Product products);
        void DeleteProduct(int Id);
    }
}
