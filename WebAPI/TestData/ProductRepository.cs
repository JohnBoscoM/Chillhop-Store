//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using WebAPI.Interface;
//using WebAPI.Data.Models;

//namespace WebAPI.TestData
//{
//    public class ProductRepository : IProductRepository 
//    {
//        public List<Product> Products = new List<Product>();
//        private Product Product1 = new Product {Id = 1, Name = "One Plus 7 pro", Description = "Best Phone Ever", Price = 899, Quantity = 10 };
//        private Product Product2 = new Product {Id = 2, Name = "Samsung Galaxy S20", Description = "Best Phone Ever", Price = 899, Quantity = 10 };
//        private Product Product3 = new Product {Id = 3, Name = "IPhone 11 Pro", Description = "Best Phone Ever", Price = 899, Quantity = 10 };
//        private Product Product4 = new Product {Id = 4, Name = "Huwaei", Description = "Best Phone Ever", Price = 899, Quantity = 10 };
//        private Product Product5 = new Product {Id = 5, Name = "Sony Xperia", Description = "Best Phone Ever", Price = 899, Quantity = 10 };

//        public ProductRepository()
//        {
//            Products.Add(Product1);
//            Products.Add(Product2);
//            Products.Add(Product3);
//            Products.Add(Product4);
//            Products.Add(Product5);
//        }
       

//        public async Task<Product> GetProduct(int id)
//        {
//            return Products.FirstOrDefault(p => p.Id == id);
//        }

//        public async Task<List<Product>> GetProducts()
//        {
//            return Products;
//        }

//    }
//}
