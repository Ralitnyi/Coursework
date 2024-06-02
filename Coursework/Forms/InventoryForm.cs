using Coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class InventoryForm : Form
    {
        private MainForm _mainForm;
        public InventoryForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            UpdateIngredientList();
        }

        private void backInventoryButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(_mainForm.MenuForm);
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            AddIngredientForm addIngredientForm = new AddIngredientForm(_mainForm.Inventory);
            addIngredientForm.ShowDialog();
            UpdateIngredientList();
        }

        private void UpdateIngredientList(List<Ingredient> listIngredients = null)
        {
            if (listIngredients == null)
            {
                List<Ingredient> result = _mainForm.Inventory.GetIngredients();
                ingredientBindingSource.DataSource = result;
                ingredientBindingSource.ResetBindings(false);
            }
            else
            {
                ingredientBindingSource.DataSource = listIngredients;
                ingredientBindingSource.ResetBindings(false);
            }
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            if (inventoryListBox.SelectedItem is Ingredient selectedIngredient)
            {
                _mainForm.Inventory.RemoveIngredient(selectedIngredient.Id);
                UpdateIngredientList();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть інгредієнт для видалення.");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text.Trim().ToLower();
            List<Ingredient> result = _mainForm.Inventory.SearchIngredient(searchTerm);
            UpdateIngredientList(result);
        }
    }
}
