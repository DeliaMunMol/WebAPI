using Entities.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Security.Authentication;
using WebApplication1.IServices;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService; 
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }
        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody]Product product)
        {
            return _productService.InsertProduct(product);
        }

        [HttpDelete(Name = "DeleteProduct")]
        public void Delete([FromQuery] int Id)
        {
            _productService.DeleteProduct(Id);

        }
        [HttpGet(Name = "GetAllProducts")]
        public List<Product> GetAll()
        {

            return _productService.GetAll();
        }
        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromBody] Product product)
        {
            {
                _productService.UpdateProduct(product);
            }
           
        }

    }
}
