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
    public partial class QuestionForm : Form
    {
        private List<string> _ingredients;
        private MainForm _mainForm;
        public QuestionForm(MainForm mainForm, List<string> ingredients)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _ingredients = ingredients;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {
            textBox.Text = $"Для рецепту не вистачає таких інгредієнтів: {string.Join(", ", _ingredients)}";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            foreach (var ing in _ingredients)
            {
                AddIngredientForm addIngredientForm = new AddIngredientForm(_mainForm.Inventory, ing);
                addIngredientForm.ShowDialog();
            }
        }
    }
}
