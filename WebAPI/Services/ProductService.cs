using System.Collections.Generic;
using MongoDB.Driver;
using ChillhopStore.Models;

namespace WebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Product> _products;   
        public ProductService(IMongoDBSettings settings, IMongoClient mongoClient)
        {
            var database = mongoClient.GetDatabase("chillhop_store");
            _products = database.GetCollection<Product>("Products");
        }
        public ProductService() { }
        public Product CreateProduct(Product product)
        {
          if(_products.Find(prod =>prod.ProductId == product.ProductId).FirstOrDefault() == null)
            {
                _products.InsertOne(product);
                return product;
            }
            return null;
        }

        public void DeleteProduct(int Id)
        {
            _products.DeleteOne(prod => prod.ProductId == Id);
        }

        public Product GetProduct(int Id)
        {
            return _products.Find(prod=> prod.ProductId == Id).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return _products.Find(prod => true).ToList();
        }

        public void UpdateProduct(int Id, Product product)
        {
            _products.ReplaceOne(prod => prod.ProductId == Id, product);
        }
    }
}
