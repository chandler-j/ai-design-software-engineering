using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeGenerator.Controllers
{
    public class ViewRecipeController : Controller
    {
        // GET: /ViewRecipe/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /ViewRecipe/Ingredients/
        public IActionResult Ingredients(string Ingredients)
        {
            ViewData["Ingredients"] = Ingredients;
            return View();
        }
    }
}

