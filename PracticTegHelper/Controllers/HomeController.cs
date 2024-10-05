using Microsoft.AspNetCore.Mvc;
using PracticTegHelper.Models;
using System.Diagnostics;

namespace PracticTegHelper.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string Index(Product product)
        {
           
            return $"Добавлен новый элемент: {product.Name} {product.Description} {product.Category} {product.Price}";
        }
    }
}
