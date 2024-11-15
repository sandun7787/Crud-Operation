using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Hosting;
using WebApplication1.Service;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        private object context;

        public ProductController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        public IActionResult Index()
        {
            var products = _context.Products.OrderByDescending(p => p.Id).ToList();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductDto productDto)
        {
            if (productDto.ImageFile == null)
            {
                ModelState.AddModelError("ImageFile", "The Image File is required");
            }

            if (!ModelState.IsValid)
            {
                return View(productDto);
            }

            // Logic to save the product to the database
            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price
            };

            // Generate a new file name
            string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff") + Path.GetExtension(productDto.ImageFile.FileName);

            // Define the full path to save the image
            string imageFullPath = Path.Combine(_environment.WebRootPath, "products", newFileName);

            // Ensure the directory exists
            Directory.CreateDirectory(Path.GetDirectoryName(imageFullPath));

            // Save the file
            using (var stream = new FileStream(imageFullPath, FileMode.Create))
            {
                productDto.ImageFile.CopyTo(stream);
            }

            //new data based save file
            Product product = new Product()
            {
                Name= productDto.Name,
                Brand= productDto.Brand,
                Category= productDto.Category,
                Price= productDto.Price,
                Description = productDto.Description,
                ImageFileName = imageFullPath,
                CreateAt = DateTime.Now,
            };

            context.Product.Add(product);
            context.SaveChanges();

            // Assign the saved image file path to the product
            product.ImagePath = $"/products/{newFileName}";

            _context.Products.Add(product);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edite(int Id)


        {

            var Product = _context.Products.Find(Id);

            if (Product == null)
            {

                return RedirectToAction("index", "Products");
            }
        }

        //Create ProductDto from Product 
        var productDto = new Product()
        {
            Name = productDto.Name,
            Brand = productDto.Brand,
            Category= productDto.Category,
            Price= productDto.Price,
            Description = productDto.Description,

        }

        return View(ProductDto);






            

    }
        [HttpPost]
    public IActionResult Edite(int Id , ProductDto)
        {
            var Product = _context.Products.Find(Id);

            if(Product == null)
            {
                return View("index", "Products");
            }

            if(!ModelState.IsValid) {
                return View(productDto);

                product.ImagePath = $"/products/{newFileName}";

                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

        public IActionResult Edite(int Id)


        {

            var Product = _context.Products.Find(Id);

            if (Product == null)
            {

                return RedirectToAction("index", "Products");
            }
        }
    }


}

