using System;
using System.Text.Json.Serialization;
using RecipeGenerator.Constant;

namespace RecipeGenerator.Models
{
	public class RecipeResponse
	{
        public class Root
        {
            [JsonPropertyName("recipe_name")]
            public string RecipeName { get; set; } = String.Empty;

            [JsonPropertyName("description")]
            public string Description { get; set; } = String.Empty;

            [JsonPropertyName("ingredients")]
            public Ingredient[] Ingredients { get; set; }

            [JsonPropertyName("ingredients")]
            public string[] Instructions { get; set; }

            [JsonPropertyName("servings")]
            public int Servings { get; set; }

            [JsonPropertyName("prep_time")]
            public string PrepTime { get; set; }

            [JsonPropertyName("cook_time")]
            public string CookTime { get; set; }

            [JsonPropertyName("total_time")]
            public string TotalTime { get; set; }

            public string ErrorMessage { get; set; } = Schema.NOERROR;
        }

        public class Ingredient
        {
            [JsonPropertyName("ingredient")]
            public string PrepIngredient { get; set; }
            [JsonPropertyName("quantity")]
            public string Quantity { get; set; }
            [JsonPropertyName("unit")]
            public string Unit { get; set; }
            [JsonPropertyName("notes")]
            public string Notes { get; set; }
        }

    }
}

