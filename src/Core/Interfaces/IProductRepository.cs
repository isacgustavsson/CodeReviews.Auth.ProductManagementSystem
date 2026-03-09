using Core.Entities;

namespace Core.Interfaces;

public interface IProductRepository
{
    public Task<List<Product>> GetAllProductsAsync();
    public Task AddProduct(Product p);
}