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
    public partial class MainForm : Form
    {
        private RecipeManager _recipeManager;
        private Inventory _inventory;
        private MenuForm _menuForm;
        private RecipeBookForm _recipeBookForm;

        public MainForm()
        {
            InitializeComponent();
            _recipeManager = new RecipeManager();
            _inventory = new Inventory();
            _recipeBookForm = new RecipeBookForm(this);
            _menuForm = new MenuForm(this);
            LoadFormInPanel(_menuForm);
        }

        public void LoadFormInPanel(Form form)
        {
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(form);
            form.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _recipeManager.SaveRecipes();
            MenuForm.SaveMenu();
        }


        public RecipeManager RecipeManager
        {
            get { return _recipeManager; }
        }
        public Inventory Inventory
        {
            get { return _inventory; }
        }

        public MenuForm MenuForm
        {
            get { return _menuForm; }
        }

        public RecipeBookForm RecipeBookForm
        {
            get { return _recipeBookForm; }
        }

    }
}
