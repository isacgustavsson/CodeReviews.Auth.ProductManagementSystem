using System.Diagnostics;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using UI.Models.ViewModels;

namespace UI.Controllers;

public class ProductController(ProductService service) : Controller
{
    private readonly ProductService _service = service;
    public async Task<IActionResult> Index()
    {
        var products = await _service.GetAllProductsAsync();
        var model = products.Select(p => new ProductViewModel
        {
            Name = p.Name,
            Price = p.Price
        }).ToList();

        return View(model);
    }
}
