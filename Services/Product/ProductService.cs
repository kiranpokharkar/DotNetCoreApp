using Demo.Constant;
using Demo.Core.Entities;
using Demo.Services.Http;
using Demo.Services.Product.Product;

namespace Demo.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly IHttpService _httpService;

        public ProductService(IHttpService httpService) { _httpService = httpService; }

        public async Task<ProductE> Get(string productId)
        {
            return await _httpService.GetAsync<ProductE>(productId);
        }

        public async Task<List<ProductE>> GetAll()
        {
            var productRes = new List<ProductE>();

            var products =  await _httpService.GetAsync<ProductResponse>(Endpoints.Products.Get);

            products.products.ForEach(product =>
            {
                productRes.Add(new ProductE() { Id = product.Id, Dimensions = new Core.Entities.Dimension() { Depth = product.Dimensions.Depth, Height = product.Dimensions.Height, Width = product.Dimensions.Width }, Title = product.Title });
            });

            return productRes;
        }
    }
}
