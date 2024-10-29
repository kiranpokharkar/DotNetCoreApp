using Demo.Core.Entities;
using Demo.Services.Product.Product;

namespace Demo.Services.Product
{
    public interface IProductService
    {
        public Task<ProductE> Get(string productId);

        public Task<List<ProductE>> GetAll();
    }
}
