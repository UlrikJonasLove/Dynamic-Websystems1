using Microsoft.AspNetCore.Mvc;
using Arkitekten.ViewModels;
using Arkitekten.Models;

namespace Arkitekten.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public ViewResult ProductList()
        {
            ProductListViewModel ProductListViewModel = new ProductListViewModel();
            ProductListViewModel.Products = _productRepository.AllProducts;

            return View(ProductListViewModel);
        }
        public IActionResult Details(int id)
        {
            var product = _productRepository.GetProductById(id);
            if (product == null)
                return NotFound();
            return View(product);
        }
    }
}