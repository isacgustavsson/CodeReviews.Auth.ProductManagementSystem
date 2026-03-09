using Core.Entities;
using Core.Interfaces;

namespace Core.Services;

public class ProductService(IProductRepository productRepository)
{
    private readonly IProductRepository _productRepository = productRepository;

    public async Task<List<Product>> GetAllProductsAsync() => await _productRepository.GetAllProductsAsync();

    // public void AddProduct()
    // {
    //     _productRepository.AddProduct();
    // }
}
