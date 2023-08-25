using Microsoft.AspNetCore.Mvc;
using CON = RecipeGenerator.Constant.Recipes;
using RecipeGenerator.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using RecipeGenerator.Constant;

namespace RecipeGenerator.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private  List<CuisineUI> Recipes;
        private readonly IWebHostEnvironment _webHostEnvironment;

        

        public HomeController(ILogger<HomeController> logger,
                              IWebHostEnvironment webHostEnvironment)
        {
            _logger = logger;
            _webHostEnvironment = webHostEnvironment;

            SetupOption();

        }

       
        public IActionResult Index(){

            
            ViewBag.Index = Recipes;
            return View();
        }



        public IActionResult GetImagePath(int id)
        {
            var selectedItem = Recipes.FirstOrDefault(item => item.Id == id);

            if (selectedItem != null)
            {

                var imagePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", selectedItem.Image);
                return Json(new { imagePath });
            }

            return Json(new { imagePath = "" });
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void SetupOption()
        {
            Recipes = new List<CuisineUI>();

            Recipes.Add(new CuisineUI(1, CON.ITALIAN, "/images/ITALIAN.jpeg"));
            Recipes.Add(new CuisineUI(2, CON.CHINESE, "/images/CHINESE.jpeg"));
            Recipes.Add(new CuisineUI(3, CON.INDIAN, "/images/INDIAN.jpeg"));
            Recipes.Add(new CuisineUI(4, CON.JAPANESE, "/images/JAPANESE.jpeg"));
            Recipes.Add(new CuisineUI(5, CON.MEXICAN, "/images/MEXICAN.jpeg"));
            Recipes.Add(new CuisineUI(6, CON.FRENCH, "/images/FRENCH.jpeg"));
            Recipes.Add(new CuisineUI(7, CON.THAI, "/images/THAI.jpeg"));
            Recipes.Add(new CuisineUI(8, CON.MEDITERRANEAN, "/images/MEDITERRANEAN.jpeg"));
            Recipes.Add(new CuisineUI(9, CON.KOREAN, "/images/KOREAN.jpeg"));
            Recipes.Add(new CuisineUI(10, CON.SPANISH, "/images/SPANISH.jpeg"));
            Recipes.Add(new CuisineUI(11, CON.VIETNAMESE, "/images/VIETNAMESE.jpeg"));
            Recipes.Add(new CuisineUI(12, CON.AMERICAN, "/images/AMERICAN.jpeg"));
            Recipes.Add(new CuisineUI(13, CON.BRAZILIAN, "/images/BRAZILIAN.jpeg"));
            Recipes.Add(new CuisineUI(14, CON.EASTERN, "/images/EASTERN.jpeg"));
        }

    }
}