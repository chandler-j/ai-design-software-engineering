using System;
namespace RecipeGenerator.Constant
{
	public class Schema
	{
		public const string SCHEMA = "{\"$schema\":\"http://json-schema.org/draft-04/schema#\",\"type\":\"object\",\"properties\":{\"recipe_name\":{\"type\":\"string\"},\"description\":{\"type\":\"string\"},\"ingredients\":{\"type\":\"array\",\"items\":{\"type\":\"object\",\"properties\":{\"ingredient\":{\"type\":\"string\"},\"quantity\":{\"type\":\"string\"},\"unit\":{\"type\":\"string\"},\"notes\":{\"type\":\"string\"}},\"additionalProperties\":false,\"required\":[\"ingredient\",\"quantity\",\"unit\"]},\"additionalItems\":false},\"instructions\":{\"type\":\"array\",\"items\":{\"type\":\"string\"},\"additionalItems\":false},\"servings\":{\"type\":\"integer\"},\"prep_time\":{\"type\":\"string\"},\"cook_time\":{\"type\":\"string\"},\"total_time\":{\"type\":\"string\"}},\"additionalProperties\":false,\"required\":[\"recipe_name\",\"description\",\"ingredients\",\"instructions\",\"servings\",\"prep_time\",\"cook_time\",\"total_time\"]}";

		public const string CHPTMODEL = "gpt-3.5-turbo";

		public const string NOERROR = "No Errors";
    }
}

