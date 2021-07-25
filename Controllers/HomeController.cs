using DotnetFormApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotnetFormApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            return View(ProductRepository.GetProducts());
        }
    }
}