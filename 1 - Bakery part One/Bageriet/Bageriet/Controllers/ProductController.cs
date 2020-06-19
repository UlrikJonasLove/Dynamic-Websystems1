using Microsoft.AspNetCore.Mvc;
using Bageriet.Models;
using Bageriet.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Bageriet.Controllers
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
    }
}
