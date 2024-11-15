using Microsoft.AspNetCore.Mvc;
using WebApplication1.Service;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller

    {
        private readonly ApplicationDbContext context;

        public ProductController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var product = context.Products.ToList();
            return View(product);
        }
    }
}
