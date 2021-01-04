using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Testing.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepo repo;

        public ProductController(IProductRepo repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            var products = repo.GetAllProducts();

            return View(products);
        }
    }
}
