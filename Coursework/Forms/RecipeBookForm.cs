using Coursework.Forms;
using Coursework.Models;
using System.Xml.Linq;

namespace Coursework
{
    public partial class RecipeBookForm : Form
    {
        private MainForm _mainForm;
        private string _originalRecipeName;

        public RecipeBookForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            UpdateRecipeList();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(_mainForm.MenuForm);
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            AddRecipe addRecipe = new AddRecipe(_mainForm);
            addRecipe.ShowDialog();
            UpdateRecipeList();
        }

        private void UpdateRecipeList(List<Recipe> recipeList = null)
        {
            if (recipeList == null)
            {
                List<Recipe> result = _mainForm.RecipeManager.GetRecipes();
                recipeBindingSource2.DataSource = result;
                recipeBindingSource2.ResetBindings(false);
            }
            else
            {
                recipeBindingSource2.DataSource = recipeList;
                recipeBindingSource2.ResetBindings(false);
            }
        }


        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = nameBox.Text.Trim().ToLower();
            List<Recipe> result = _mainForm.RecipeManager.SearchRecipes(searchTerm);
            UpdateRecipeList(result);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (recipeslistBox.SelectedItem is Recipe selectedRecipe)
            {
                _mainForm.RecipeManager.RemoveRecipe(selectedRecipe.Id);
                UpdateRecipeList();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рецепт для видалення.");
            }
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {

            if (recipeslistBox.SelectedItem is Recipe selectedRecipe)
            {
                _mainForm.MenuForm.AddRecipeToMenu(selectedRecipe);
            }
        }

        private void recipeslistBox_DobleClick(object sender, EventArgs e)
        {
            if (recipeslistBox.SelectedItem is Recipe selectedRecipe)
            {
                EditRecipeForm editRecipeForm = new EditRecipeForm(selectedRecipe);
                editRecipeForm.ShowDialog();
                _mainForm.RecipeManager.SaveRecipes();
                UpdateRecipeList();
            }
        }
    }
}
