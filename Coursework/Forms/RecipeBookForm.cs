using Coursework.Forms;
using Coursework.Models;

namespace Coursework
{
    public partial class RecipeBookForm : Form
    {
        private RecipeManager _recipeManager;
        private MainForm _mainForm;

        public RecipeBookForm(MainForm mainForm, RecipeManager recipeManager)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _recipeManager = recipeManager;
            UpdateRecipeList();
        }

        private void recipeslistBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            // remove later
            UpdateRecipeList();

        }

        private void RecipeBookForm_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(new MenuForm(_mainForm, _recipeManager));
        }

        private void newRecipeButton_Click(object sender, EventArgs e)
        {
            AddRecipe addRecipe = new AddRecipe(_recipeManager);
            addRecipe.ShowDialog();
            UpdateRecipeList();
        }

        private void UpdateRecipeList()
        {
            List<Recipe> result = _recipeManager.GetRecipes();
            recipeBindingSource2.DataSource = result;
            recipeBindingSource2.ResetBindings(false);
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void ingredientsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click_1(object sender, EventArgs e)
        {
            UpdateRecipeList();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (recipeslistBox.SelectedItem is Recipe selectedRecipe)
            {
                _recipeManager.RemoveRecipe(selectedRecipe.Id);
                UpdateRecipeList();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть рецепт для видалення.");
            }
        }
    }
}
