using Microsoft.AspNetCore.Mvc;
using onlinePharmacy_Mvc.Data;
using onlinePharmacy_Mvc.Models;

namespace onlinePharmacy_Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        

        public ProductController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            List<Product> allProducts = _db.products.ToList();
            if (allProducts == null)
            {
                return NotFound();
            }

            return View(allProducts);
        }


        public IActionResult SearchProduct(string? searchString)
        {
            if (searchString == null)
            {
                return View();
            }

            List<Product> relatedProducts = _db.products.Where(p => p.ProductName.Contains(searchString)).ToList();


            return View(relatedProducts);
        }

        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProduct product)
        {
            if (ModelState.IsValid)
            {
                if (product == null)
                {
                    return BadRequest();
                }

                Product newProduct = new Product()
                {
                    ProductID = Guid.NewGuid(),
                    ProductName = product.ProductName,
                    ProductDescription = product.ProductDescription,
                    ProductCategory = product.ProductCategory,
                    Brand = product.Brand,
                    Price = product.Price,
                    QuantityInStock = product.QuantityInStock
                };

                if (product.SpecialTag != null)
                {
                    newProduct.SpecialTag = product.SpecialTag;
                }

                if (product.ImageFile != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath;


                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(product.ImageFile.FileName);
                    string imgPath = Path.Combine(wwwRootPath, @"images\product");

                    using (var fileStream = new FileStream(Path.Combine(imgPath, fileName), FileMode.Create))
                    {
                        product.ImageFile.CopyTo(fileStream);
                    }

                    newProduct.ImageUrl = @"\images\product\" + fileName;
                }
                _db.products.Add(newProduct);
                _db.SaveChanges();

                TempData["success"] = "A New Product Added";
                return RedirectToAction("Index", "Product");

            }
            else
            {
                return View();
            }
        }

        public IActionResult UpdateProduct(Guid? productId)
        {
            Product? productTobeUpdated = _db.products.Find(productId);
            return View(productTobeUpdated);
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product, IFormFile imageFile)
        {

            if (product != null)
            {
                if (imageFile != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath;


                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                    string imgPath = Path.Combine(wwwRootPath, @"images\product");

                    using (var fileStream = new FileStream(Path.Combine(imgPath, fileName), FileMode.Create))
                    {
                        imageFile.CopyTo(fileStream);
                    }

                    product.ImageUrl = @"\images\product\" + fileName;
                }

                _db.products.Update(product);


                _db.SaveChanges();
                return RedirectToAction("Index", "Product");
            }
            else
            {
                return View(product);
            }
                
        }

        public IActionResult DeleteProduct(Guid productId)
        {
            Product? productToDelete = _db.products.Find(productId);

            if (productToDelete != null)
            {
                _db.products.Remove(productToDelete);
                _db.SaveChanges();
            }
            return RedirectToAction("Index", "Product");
        }


        public IActionResult ProductDetails(Guid productId)
        {
            Product? product = _db.products.Find(productId);
            return View(product);
        }

    }
    
}


