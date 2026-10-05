using System.Collections.Generic;
using System.Web.Mvc;
using ProductCatalog_PRACTIAL_6.Models;

namespace ProductCatalog_PRACTIAL_6.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Category = "Electronics",
                    Price = 55000,
                    Description = "Laptop for students"
                },
                new Product
                {
                    Id = 2,
                    Name = "Smartphone",
                    Category = "Electronics",
                    Price = 25000,
                    Description = "Modern smartphone"
                },
                new Product
                {
                    Id = 3,
                    Name = "Headphones",
                    Category = "Accessories",
                    Price = 2000,
                    Description = "Wireless headphones"
                }
            };

            return View(products);
        }
    }
}