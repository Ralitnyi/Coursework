using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class Inventory
    {
        private List<Ingredient> _ingredients;

        public Inventory()
        {
            _ingredients = new List<Ingredient>();
            LoadIngredients();
        }

        public void AddIngredient(Ingredient ingredient)
        {
            _ingredients.Add(ingredient);
            SaveIngredients();
        }

        public List<Ingredient> SearchIngredient(string searchTerm)
        {
            List<Ingredient> result = _ingredients
            .Where(i => i.Name.StartsWith(searchTerm, StringComparison.OrdinalIgnoreCase))
            .ToList();
            return result;
        }


        public void RemoveIngredient(int ingredientId)
        {
            Ingredient ingredientToRemove = _ingredients.FirstOrDefault(i => i.Id == ingredientId);
            if (ingredientToRemove != null)
            {
                _ingredients.Remove(ingredientToRemove);
                SaveIngredients();
            }
        }

        public List<Ingredient> GetIngredients()
        {
            return _ingredients;
        }

        public List<string> IsDontHaveIngredients(List<string> ingredientNames)
        {
            List<string> result = new List<string>();
            foreach (var ing in ingredientNames)
            {
                if (_ingredients.Find(i => i.Name == ing) != null)
                {
                    continue;
                }
                else
                {
                    result.Add(ing);
                }
            }
            return result;
        }

        private void SaveIngredients()
        {
            string json = JsonConvert.SerializeObject(_ingredients, Formatting.Indented);
            File.WriteAllText("ingredients.json", json);
        }

        private void LoadIngredients()
        {
            if (File.Exists("ingredients.json"))
            {
                string json = File.ReadAllText("ingredients.json");
                _ingredients = JsonConvert.DeserializeObject<List<Ingredient>>(json) ?? new List<Ingredient>();
            }
        }
    }
}
