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
    public partial class RecipeForm : Form
    {
        private Recipe _recipe;
        private MainForm _mainForm;
        public RecipeForm(MainForm mainForm, Recipe recipe)
        {
            InitializeComponent();
            _recipe = recipe;
            _mainForm = mainForm;
            LoadRecipeDetails();
        }

        private void LoadRecipeDetails()
        {
            nameBox.Text = _recipe.Name;
            descriptionBox.Text = _recipe.Description;
            ingredientsBox.Text = _recipe.IngredientsAsString;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(_mainForm.MenuForm);
        }

    }
}
