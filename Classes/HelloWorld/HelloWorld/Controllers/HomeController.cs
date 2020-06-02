using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private IProductRepository productRepository;

        public HomeController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public IActionResult Product()
        {
            return View(productRepository.Products.First());
        }

        public IActionResult Products()
        {
            return View(productRepository.Products);
        }
        [HttpGet]
        public IActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult RsvpForm(Models.GuestResponse guestResponse)
        {
            if(ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            return View();
        }
    }
}