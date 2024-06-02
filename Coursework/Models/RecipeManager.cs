using Coursework.Forms;
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

        public Recipe GetRecipeByName(string name)
        {
            return _recipes.Find(recipe => recipe.Name == name);
        }

        public List<Recipe> GetRecipes()
        {
            return _recipes;
        }

        public bool RecipeExists(string name)
        {
            return _recipes.Any(recipe => recipe.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public List<Recipe> SearchRecipes(string searchTerm)
        {
            List<Recipe> result = _recipes
            .Where(r => r.Name.StartsWith(searchTerm, StringComparison.OrdinalIgnoreCase))
            .ToList();
            return result;
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

        public string GetDailyRecipeName(Inventory inventory)
        {
            Recipe resultRecipe = null;
            List<Ingredient> ingredients = inventory.GetIngredients();
            float maxScore = 0;

            foreach (Recipe recipe in _recipes)
            {
                int totalIngredientsNeeded = recipe.Ingredients.Count;
                float score = 0;
                bool allIngredientsAvailable = true;

                foreach (BaseIngredient ing in recipe.Ingredients)
                {
                    if (!ingredients.Any(i => i.Name == ing.Name))
                    {
                        allIngredientsAvailable = false;
                        break; // Якщо інгредієнт відсутній, виходимо з циклу
                    }

                    float countIng = ingredients.Find(i => i.Name == ing.Name).Quantity;
                    if (countIng >= ing.Quantity)
                    {
                        float diff = countIng - ing.Quantity;
                        float multiplier = 1.0f / totalIngredientsNeeded;
                        score += diff * multiplier;
                    }
                    else
                    {
                        allIngredientsAvailable = false;
                        break; // Якщо кількість інгредієнту менша за необхідну, виходимо з циклу
                    }
                }

                // Перевіряємо, чи всі інгредієнти доступні для цієї рецептури
                if (allIngredientsAvailable)
                {
                    if (score > maxScore)
                    {
                        resultRecipe = recipe;
                        maxScore = score;
                    }
                }
            }

            if (resultRecipe != null)
            {
                return resultRecipe.Name;
            }
            return null;
        }


        public void SaveRecipes()
        {
            string json = JsonConvert.SerializeObject(_recipes, Formatting.Indented);
            File.WriteAllText("recipes.json", json);
        }

        private void LoadRecipes()
        {
            if (!File.Exists("recipes.json"))
            {
                var sampleRecipe = new Recipe
                (
                   "Назва рецепту",
                    "Рецепт приготування.",
                    new List<BaseIngredient>()
                );

                var recipes = new List<Recipe> { sampleRecipe };

                string json = JsonConvert.SerializeObject(recipes, Formatting.Indented);

                File.WriteAllText("recipes.json", json);
            }

            string fileContent = File.ReadAllText("recipes.json");
            _recipes = JsonConvert.DeserializeObject<List<Recipe>>(fileContent) ?? new List<Recipe>();
        }
    }
}
