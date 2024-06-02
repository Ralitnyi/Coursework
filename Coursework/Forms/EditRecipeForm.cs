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
    public partial class EditRecipeForm : Form
    {
        private Recipe _recipe;
        public EditRecipeForm(Recipe recipe)
        {
            InitializeComponent();
            _recipe = recipe;
        }

        private void EditRecipeForm_Load(object sender, EventArgs e)
        {
            nameTextBox.Text = _recipe.Name;
            descriptionTextBox.Text = _recipe.Description;
            ingredientsTextBox.Text = _recipe.IngredientNamesAsString;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _recipe.Name = nameTextBox.Text;
            _recipe.Description = descriptionTextBox.Text;
            string ingredientsText = ingredientsTextBox.Text;
            if (!(ingredientsText == _recipe.IngredientNamesAsString))
            {
                List<string> ingredientsNames = Recipe.ParseIngredients(ingredientsText);

                CountIngredientsForm countIngredientsForm = new CountIngredientsForm(ingredientsNames);
                countIngredientsForm.ShowDialog();

                List<BaseIngredient> ingredients = countIngredientsForm.GetIngredients();
                _recipe.Ingredients = ingredients;
            }
            Close();
        }
    }
}
