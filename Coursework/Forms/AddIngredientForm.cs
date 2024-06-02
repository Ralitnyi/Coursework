using Coursework.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Coursework.Forms
{
    public partial class AddIngredientForm : Form
    {
        private Inventory _inventory;
        public AddIngredientForm(Inventory inventory, string ingName = null)
        {
            InitializeComponent();
            _inventory = inventory;
            nameBox.Text = ingName;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameBox.Text) || string.IsNullOrEmpty(priceBox.Text) || string.IsNullOrEmpty(countBox.Text))
            {
                MessageBox.Show("Всі поля мають бути заповнені", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string name = nameBox.Text.Trim();
                decimal price = decimal.Parse(priceBox.Text);
                float count = float.Parse(countBox.Text);
                DateTime expirationDate = dateTimePicker.Value;

                Ingredient newIngredient = new Ingredient(name, price, count, expirationDate);
                _inventory.AddIngredient(newIngredient);
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некоректний ввід в поле. Введіть числове значення для ціни та кількості.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
