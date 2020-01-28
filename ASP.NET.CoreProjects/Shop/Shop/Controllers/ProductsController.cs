using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstWebProjectOnASP.NETCore.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebProjectOnASP.NETCore.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult ProductList()
        {
            List<ProductVM> products = new List<ProductVM>();
            ProductVM model = new ProductVM
            {
                Id = 1,
                Name = "i9-9900",
                Price = 25000
            };
            products.Add(model);
            products.Add(new ProductVM
            {
                Id = 2,
                Name = "i7-7700",
                Price = 8000
            });
            return Ok(products);
        }
    }
}