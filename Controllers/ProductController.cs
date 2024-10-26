using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using THUCHANH.Repository;

namespace THUCHANH.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductController(IProductRepository _productRepository)
        {
            productRepository = _productRepository;
        }


        [HttpGet]
        public IActionResult getProducts()
        {
            var products = productRepository.getAll();
            return Ok(products);
        }
    }
}
