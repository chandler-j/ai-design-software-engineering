using System;
namespace RecipeGenerator.Models
{
	public class CuisineUI
	{

        private int _id =0;
        private string _name = "";
        private string _image = "";
      

        public CuisineUI(int id, string name, string image)
        {
            _id = id;
            _name = name;
            _image = image;

        }

        public int Id { get { return this._id; } init { this._id = value; } }
        public string Name { get { return this._name; } init { this._name = value; } }
        public string Image { get { return this._image; } init { this._image = value; } }
      
		
			
	}
}

