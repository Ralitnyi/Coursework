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
    public partial class MenuForm : Form
    {
        private MainForm _mainForm;
        private RecipeBookForm _recipeBookForm;
        private RecipeManager _recipeManager;
        public MenuForm(MainForm mainForm, RecipeManager recipeManager)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _recipeManager = recipeManager;
            _recipeBookForm = new RecipeBookForm(_mainForm, _recipeManager);
        }

        private void recipeButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(_recipeBookForm);
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(new InventoryForm(_mainForm));
        }
    }
}
