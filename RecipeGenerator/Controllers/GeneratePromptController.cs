using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RecipeGenerator.Controllers
{
    public class GeneratePromptController : Controller
    {
        // GET: /GeneratePrompt/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /GeneratePrompt/Form/
        public IActionResult Form(string Ingredients)
        {
            ViewData["Ingredients"] = "The list of ingredients is " + Ingredients;
            return View();
        }
        //[HttpPost]
        //public ActionResult ShowPreferences()
        //{
        //    //String Ingredients = Convert.ToString(Request["Ingredients"]);
        //    RecipePreferencesModel preferences = new RecipePreferencesModel();
        //    //preferences.Ingredients = Ingredients;
        //    ViewData["RecipePreferencesModel"] = preferences;
        //    return View("DisplayPreferences");
        //}

    }
}

