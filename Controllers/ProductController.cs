using Demo.Services.Product;
using Microsoft.AspNetCore.Mvc;
using static Demo.Constant.Endpoints;

namespace Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
 
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet(Name = ApiRoutes.Product.Get)]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await _productService.GetAll());
        }
    }
}
