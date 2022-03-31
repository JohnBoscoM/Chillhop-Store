using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Interface;
using WebAPI.Services;
using WebAPI.Data.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: api/<controller>'
      
        [HttpGet]
        public async Task<ActionResult> GetProducts(int id)
        {   
            try
            {
                var products = _productService.GetProducts();
                return Ok(products);
            }
            catch (Exception e)
            {
                return StatusCode(500, new { ErrorMessage = e.Message });
            }
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            try
            {
                var product = _productService.GetProduct(id);
                return Ok(product);
            }
            catch(Exception e)
            {
                return StatusCode(500, new { ErrorMessage = e.Message });
            }          
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody] Product product)
        {

        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product product)
        {
            //try
            //{
            //    var prod = productService.GetProduct(id);
            //    productService.UpdateProduct(id, product);             
           

        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
