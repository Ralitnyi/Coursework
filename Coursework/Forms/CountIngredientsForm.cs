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
    public partial class CountIngredientsForm : Form
    {
        private List<BaseIngredient> _ingredients;

        public CountIngredientsForm(List<string> ingredientNames)
        {
            InitializeComponent();
            _ingredients = ingredientNames.Select(name => new BaseIngredient(name, 0)).ToList();

            foreach (var ingredient in _ingredients)
            {
                var label = new Label { Text = ingredient.Name, AutoSize = true };
                var numericUpDown = new NumericUpDown { Minimum = 0, Maximum = 1000, Tag = ingredient };

                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(numericUpDown);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if (control is NumericUpDown numericUpDown)
                {
                    var ingredient = (BaseIngredient)numericUpDown.Tag;
                    ingredient.Quantity = (int)numericUpDown.Value;
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        public List<BaseIngredient> GetIngredients()
        {
            if (DialogResult == DialogResult.OK)
                { return _ingredients; }
            return null;
        }
    }
}
