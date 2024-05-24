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
    public partial class InventoryForm : Form
    {
        private MainForm _mainForm;
        public InventoryForm(MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
        }

        private void backInventoryButton_Click(object sender, EventArgs e)
        {
            _mainForm.LoadFormInPanel(new MenuForm(_mainForm, _mainForm.RecipeManager));
        }
    }
}
