using Coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
        private MainForm _mainForm;
        public AddRecipe(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void saveRecipeButton_Click(object sender, EventArgs e)
        {
            string name = nameBox.Text.ToLower().Trim();
            if (_mainForm.RecipeManager.RecipeExists(name))
            {
                MessageBox.Show("Рецепт з такою назвою вже існує. Будь ласка, виберіть іншу назву.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string description = recipeBox.Text;
            List<string> ingredientsNames = Recipe.ParseIngredients(ingredientsBox.Text.Trim());

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description) || ingredientsNames.Count() == 0)
            {
                {
                    MessageBox.Show("Всі поля мають бути заповнені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            CountIngredientsForm countIngredientsForm = new CountIngredientsForm(ingredientsNames);
            countIngredientsForm.ShowDialog();

            List<string> ingredientsToAdd = _mainForm.Inventory.IsDontHaveIngredients(ingredientsNames);
            if (ingredientsToAdd.Count() > 0)
            {
                QuestionForm questionForm = new QuestionForm(_mainForm, ingredientsToAdd);
                questionForm.ShowDialog();

            }

            List<BaseIngredient> ingredients = countIngredientsForm.GetIngredients();
            _mainForm.RecipeManager.AddRecipe(new Recipe(name, description, ingredients));
            Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
