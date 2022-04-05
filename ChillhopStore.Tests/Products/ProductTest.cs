using ChillhopStore.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WebAPI.Services;

namespace ChillhopStore.Products.Tests
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void Can_get_productlist()
        {
            //Arrange
            var prodList = new List<Product>();
            var productService = new ProductService();

            //Act 
            prodList = productService.GetProducts();
            
            //Assert
            Assert.IsNotNull(prodList);
        }
    }
}
