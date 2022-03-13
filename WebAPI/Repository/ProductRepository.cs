//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using WebAPI.Data.Models;
//using WebAPI.Interface;

//namespace WebAPI.Data.Repository
//{
//    public class ProductRepository : IProductRepository 
//    {
//        WebShopDB db = new WebShopDB();
  
//       public List<Product> GetProducts()
//        {
//            return db.Products.ToList();
//        }
//        public Product GetProduct(int id)
//        {
//            return db.Products.FirstOrDefault(p => p.Id == id);
//        }
//    }
//}
 