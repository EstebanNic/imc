using Microsoft.AspNetCore.Mvc;
using imc.Models;

namespace imc.Controllers
{
    public class imcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CalcularIMC(imcModels models){
            if (ModelState.IsValid)
            {
                return View("Resultado",models);
            }
            return View("Index");


        
        }
    }
}
