using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class RecipeManager
    {
        private List<Recipe> _recipes;

        public RecipeManager()
        {
            LoadRecipes();
        }

        public void AddRecipe(Recipe recipe)
        {
            _recipes.Add(recipe);
            SaveRecipes();
        }

        public List<Recipe> GetRecipes()
        {
            return _recipes;
        }

        public void RemoveRecipe(int recipeId)
        {
            Recipe recipeToRemove = _recipes.Find(r => r.Id == recipeId);
            if (recipeToRemove != null)
            {
                _recipes.Remove(recipeToRemove);
                SaveRecipes();
            }
        }

        public void SaveRecipes()
        {
            string json = JsonConvert.SerializeObject(_recipes, Formatting.Indented);
            File.WriteAllText("recipes.json", json);
        }

        private void LoadRecipes()
        {
            if (File.Exists("recipes.json"))
            {
                string json = File.ReadAllText("recipes.json");
                _recipes = JsonConvert.DeserializeObject<List<Recipe>>(json) ?? new List<Recipe>();
            }
        }
    }
}
