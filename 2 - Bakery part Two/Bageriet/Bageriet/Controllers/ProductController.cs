using Microsoft.AspNetCore.Mvc;
using Bageriet.Models;
using Bageriet.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly AppDbContext _appDbContext;

        public ProductController(IProductRepository productRepository, ICategoryRepository categoryRepository, AppDbContext appDbContext)
        {
            _productRepository = productRepository;
            _categoryRepository = categoryRepository;
            _appDbContext = appDbContext;
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
