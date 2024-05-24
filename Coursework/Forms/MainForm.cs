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
        public MainForm()
        {
            InitializeComponent();
            _recipeManager = new RecipeManager();
            MenuForm menuForm = new MenuForm(this, _recipeManager);
            LoadFormInPanel(menuForm);
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
        }

        public RecipeManager RecipeManager
        {
            get { return _recipeManager; }
        }

    }
}
