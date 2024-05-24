using Coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class AddRecipe : Form
    {
        private RecipeManager _recipeManager;
        public AddRecipe(RecipeManager recipeManager)
        {
            InitializeComponent();
            _recipeManager = recipeManager;
        }

        private void saveRecipeButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text.ToLower().Replace(" ", "");
            string description = recipeBox.Text;
            List<string> ingredients = ParseIngredients(ingredientsBox.Text); 
            _recipeManager.AddRecipe(new Recipe(name, description, ingredients));
            Close();
        }

        private List<string> ParseIngredients(string ingredientsInput)
        {
            return ingredientsInput
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(ingredient => ingredient.Trim().ToLower())
                .ToList();
        }

    }
}
