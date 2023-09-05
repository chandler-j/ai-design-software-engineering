using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeGenerator.Models
{
	public class Prompt
	{
        [DataType(DataType.Text)]
        public string Ingredients { get; set; }
        [Display(Name = "Cuisine Type")]
        [DataType(DataType.Text)]
        public string? CuisineType { get; set; } // ? meanse it's nullable
    }
}

