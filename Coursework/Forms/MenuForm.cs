using Coursework.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SystemFont = System.Drawing.Font;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Coursework.Forms
{
    public partial class MenuForm : Form
    {
        private MainForm _mainForm;
        private List<Recipe> _menu;

        public MenuForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _menu = new List<Recipe>();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            _menu = LoadMenu();
            GetMenu();
        }

        private void GetMenu()
        {
            recipeBindingSource.DataSource = _menu;
            recipeBindingSource.ResetBindings(false);
        }

        public void AddRecipeToMenu(Recipe newRecipe)
        {
            if (!_menu.Any(recipe => recipe.Name == newRecipe.Name))
            {
                _menu.Add(newRecipe);
                GetMenu();
                SaveMenu();
            }
        }

        public void SaveMenu()
        {
            string json = JsonConvert.SerializeObject(_menu, Formatting.Indented);
            File.WriteAllText("menu.json", json);
        }

        private List<Recipe> LoadMenu()
        {
            if (File.Exists("menu.json"))
            {
                string json = File.ReadAllText("menu.json");
                return JsonConvert.DeserializeObject<List<Recipe>>(json) ?? new List<Recipe>();
            }
            return new List<Recipe>();
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(_mainForm.RecipeBookForm);
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(new InventoryForm(_mainForm));
        }

        private void menuListBox_DoubleClick(object sender, EventArgs e)
        {
            if (menuListBox.SelectedItem is Recipe selectedRecipe)
            {
                _mainForm.LoadFormInPanel(new RecipeForm(_mainForm, selectedRecipe));
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (menuListBox.SelectedItem is Recipe selectedRecipe)
            {
                _menu.Remove(selectedRecipe);
                SaveMenu();
                GetMenu();
            }
            else
            {
                MessageBox.Show("Виберіть рецепт для видалення.");
            }
        }

        private void removeAllButton_Click(object sender, EventArgs e)
        {
            _menu = new List<Recipe>();
            SaveMenu();
            GetMenu();
        }

        private void dailyRecipeButton_Click(object sender, EventArgs e)
        {
            string recipe = _mainForm.RecipeManager.GetDailyRecipeName(_mainForm.Inventory);
            if (recipe != null)
            {
                dailyRecipeBox.Text = recipe;
            }
            else
            {
                dailyRecipeBox.Text = "";
                MessageBox.Show("Немає рецепту дня з урахування запасів на складі.");
            }

        }

        private void dailyRecipeBox_DoubleClick(object sender, EventArgs e)
        {
            string recipeName = dailyRecipeBox.Text;
            Recipe recipe = _mainForm.RecipeManager.GetRecipeByName(recipeName);
            AddRecipeToMenu(recipe);
        }

        private void extractButton_Click(object sender, EventArgs e)
        {
            if (_menu.Count < 1) 
            {
                MessageBox.Show("Меню порожнє.");
                return; 
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Title = "Зберегти виписку на склад"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                CreateInventoryExtract(saveFileDialog.FileName);
                MessageBox.Show("Виписка на склад успішно збережена.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void CreateInventoryExtract(string filePath)
        {
            var inventory = _mainForm.Inventory;
            var neededIngredients = new Dictionary<string, float>();

            foreach (var recipe in _menu)
            {
                foreach (var ingredient in recipe.Ingredients)
                {
                    if (neededIngredients.ContainsKey(ingredient.Name))
                    {
                        neededIngredients[ingredient.Name] += ingredient.Quantity;
                    }
                    else
                    {
                        neededIngredients.Add(ingredient.Name, ingredient.Quantity);
                    }
                }
            }

            foreach (var ingredient in inventory.GetIngredients())
            {
                if (neededIngredients.ContainsKey(ingredient.Name))
                {
                    neededIngredients[ingredient.Name] -= ingredient.Quantity;
                    if (neededIngredients[ingredient.Name] <= 0)
                    {
                        neededIngredients.Remove(ingredient.Name);
                    }
                }
            }

            Aspose.Pdf.Document doc = new Aspose.Pdf.Document();

            Aspose.Pdf.Page page = doc.Pages.Add();

            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"Дата створення: {DateTime.Now.ToShortDateString()}"));
            page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment("\n\nВиписка на склад"));

            foreach (var entry in neededIngredients)
            {
                page.Paragraphs.Add(new Aspose.Pdf.Text.TextFragment($"{entry.Key}: {entry.Value}"));
            }

            doc.Save(filePath);
            doc.Dispose();
        }
    }
}
