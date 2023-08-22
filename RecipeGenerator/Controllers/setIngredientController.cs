
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

//using System.Runtime.InteropServices.JavaScript;

namespace RecipeGenerator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class setIngredientController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("hello world");
        }

        [HttpPost]
        public IActionResult Post(JObject payload)
        {
            var response = "Here's your list of ingredients: " + payload;
            return Ok(response);
        }
    }
}
