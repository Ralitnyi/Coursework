using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class Recipe
    {
        private static int _currentId = 0;
        private int _id;
        private string _name;
        private string _description;
        private List<string> _ingredients;

        public Recipe(string name, string description, List<string> ingredients)
        {
            Id = _currentId++;
            Name = name;
            Description = description;
            Ingredients = ingredients;
        }

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }


        public string Name
        {
            get { return _name; }
            set
            {
                if (value.Length >= 3 && value.Length <= 50)
                {
                    _name = value;
                }
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (value.Length > 0 && value.Length <= 500)
                {
                    _description = value;
                }
            }
        }

        public List<string> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value; } 
        }

        public string IngredientsAsString
        {
            get { return string.Join(", ", _ingredients); }
        }

    }
}
