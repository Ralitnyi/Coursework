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
        private List<BaseIngredient> _ingredients;

        public Recipe(string name, string description, List<BaseIngredient> ingredients)
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
                if (!string.IsNullOrEmpty(value) && value.Length >= 1 && value.Length <= 50)
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Name must be between 1 and 50 characters.");
                }
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrEmpty(value) && value.Length <= 500)
                {
                    _description = value;
                }
                else
                {
                    throw new ArgumentException("Description cannot be empty and must be less than 500 characters.");
                }
            }
        }

        public List<BaseIngredient> Ingredients
        {
            get { return _ingredients; }
            set { _ingredients = value ?? new List<BaseIngredient>(); }
        }

        public string IngredientsAsString
        {
            get
            {
                return string.Join(", ", _ingredients.Select(i => i.Quantity > 0 ? $"{i.Name} ({i.Quantity})" : i.Name));
            }
        }

        public string IngredientNamesAsString
        {
            get { return string.Join(", ", _ingredients.Select(i => i.Name)); }
        }

        public static List<string> ParseIngredients(string ingredientsInput)
        {
            var ingredients = new List<string>();

            var separators = new char[] { ',', ' ', '\n', '\r' };
            var parts = ingredientsInput.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                string name = part.Trim();
                if (!string.IsNullOrEmpty(name))
                {
                    ingredients.Add(name);
                }
            }

            return ingredients;
        }
    }
}
