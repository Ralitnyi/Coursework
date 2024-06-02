namespace Coursework.Forms
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            ingredientBindingSource = new BindingSource(components);
            searchBox = new TextBox();
            searchButton = new Button();
            backInventoryButton = new Button();
            countIngredientBox = new TextBox();
            priceIngredientBox = new TextBox();
            nameIngredientBox = new TextBox();
            removeIngredientButton = new Button();
            addIngredientButton = new Button();
            inventoryListBox = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(searchBox);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(backInventoryButton);
            panel1.Controls.Add(countIngredientBox);
            panel1.Controls.Add(priceIngredientBox);
            panel1.Controls.Add(nameIngredientBox);
            panel1.Controls.Add(removeIngredientButton);
            panel1.Controls.Add(addIngredientButton);
            panel1.Controls.Add(inventoryListBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 680);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker1.CalendarMonthBackground = Color.White;
            dateTimePicker1.DataBindings.Add(new Binding("Text", ingredientBindingSource, "ExpirationDate", true));
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Font = new Font("Segoe UI", 14F);
            dateTimePicker1.Location = new Point(850, 326);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 39);
            dateTimePicker1.TabIndex = 10;
            // 
            // ingredientBindingSource
            // 
            ingredientBindingSource.DataSource = typeof(Models.Ingredient);
            // 
            // searchBox
            // 
            searchBox.AccessibleName = "";
            searchBox.BackColor = Color.Silver;
            searchBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchBox.Location = new Point(18, 9);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Назва:";
            searchBox.Size = new Size(267, 38);
            searchBox.TabIndex = 9;
            searchBox.Tag = "";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top;
            searchButton.BackColor = Color.FromArgb(64, 64, 64);
            searchButton.Font = new Font("Segoe UI", 14F);
            searchButton.ForeColor = Color.White;
            searchButton.Location = new Point(324, 3);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(220, 48);
            searchButton.TabIndex = 8;
            searchButton.Text = "Пошук";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // backInventoryButton
            // 
            backInventoryButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backInventoryButton.BackColor = Color.FromArgb(64, 64, 64);
            backInventoryButton.Font = new Font("Segoe UI", 14F);
            backInventoryButton.ForeColor = Color.White;
            backInventoryButton.Location = new Point(956, 590);
            backInventoryButton.Name = "backInventoryButton";
            backInventoryButton.Size = new Size(163, 74);
            backInventoryButton.TabIndex = 7;
            backInventoryButton.Text = "Назад";
            backInventoryButton.UseVisualStyleBackColor = false;
            backInventoryButton.Click += backInventoryButton_Click;
            // 
            // countIngredientBox
            // 
            countIngredientBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            countIngredientBox.BackColor = Color.Silver;
            countIngredientBox.DataBindings.Add(new Binding("Text", ingredientBindingSource, "Quantity", true));
            countIngredientBox.Font = new Font("Segoe UI", 16F);
            countIngredientBox.Location = new Point(850, 159);
            countIngredientBox.Name = "countIngredientBox";
            countIngredientBox.ReadOnly = true;
            countIngredientBox.Size = new Size(218, 43);
            countIngredientBox.TabIndex = 6;
            // 
            // priceIngredientBox
            // 
            priceIngredientBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            priceIngredientBox.BackColor = Color.Silver;
            priceIngredientBox.DataBindings.Add(new Binding("Text", ingredientBindingSource, "Price", true));
            priceIngredientBox.Font = new Font("Segoe UI", 16F);
            priceIngredientBox.Location = new Point(850, 245);
            priceIngredientBox.Name = "priceIngredientBox";
            priceIngredientBox.ReadOnly = true;
            priceIngredientBox.Size = new Size(216, 43);
            priceIngredientBox.TabIndex = 4;
            // 
            // nameIngredientBox
            // 
            nameIngredientBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameIngredientBox.BackColor = Color.Silver;
            nameIngredientBox.DataBindings.Add(new Binding("Text", ingredientBindingSource, "Name", true));
            nameIngredientBox.Font = new Font("Segoe UI", 16F);
            nameIngredientBox.Location = new Point(850, 75);
            nameIngredientBox.Name = "nameIngredientBox";
            nameIngredientBox.ReadOnly = true;
            nameIngredientBox.Size = new Size(218, 43);
            nameIngredientBox.TabIndex = 3;
            // 
            // removeIngredientButton
            // 
            removeIngredientButton.Anchor = AnchorStyles.Top;
            removeIngredientButton.BackColor = Color.FromArgb(64, 64, 64);
            removeIngredientButton.Font = new Font("Segoe UI", 14F);
            removeIngredientButton.ForeColor = Color.White;
            removeIngredientButton.Location = new Point(633, 3);
            removeIngredientButton.Name = "removeIngredientButton";
            removeIngredientButton.Size = new Size(220, 48);
            removeIngredientButton.TabIndex = 2;
            removeIngredientButton.Text = "Видалити";
            removeIngredientButton.UseVisualStyleBackColor = false;
            removeIngredientButton.Click += removeIngredientButton_Click;
            // 
            // addIngredientButton
            // 
            addIngredientButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            addIngredientButton.BackColor = Color.FromArgb(64, 64, 64);
            addIngredientButton.Font = new Font("Segoe UI", 14F);
            addIngredientButton.ForeColor = Color.White;
            addIngredientButton.Location = new Point(912, 3);
            addIngredientButton.Name = "addIngredientButton";
            addIngredientButton.Size = new Size(220, 48);
            addIngredientButton.TabIndex = 1;
            addIngredientButton.Text = "Додати";
            addIngredientButton.UseVisualStyleBackColor = false;
            addIngredientButton.Click += addIngredientButton_Click;
            // 
            // inventoryListBox
            // 
            inventoryListBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            inventoryListBox.BackColor = Color.Gray;
            inventoryListBox.DataSource = ingredientBindingSource;
            inventoryListBox.DisplayMember = "Name";
            inventoryListBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.ItemHeight = 31;
            inventoryListBox.Location = new Point(3, 75);
            inventoryListBox.MultiColumn = true;
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(756, 562);
            inventoryListBox.TabIndex = 0;
            inventoryListBox.ValueMember = "Id";
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1159, 704);
            Controls.Add(panel1);
            MinimumSize = new Size(1177, 751);
            Name = "InventoryForm";
            Text = "InventoryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ingredientBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox countIngredientBox;
        private TextBox priceIngredientBox;
        private TextBox nameIngredientBox;
        private Button removeIngredientButton;
        private Button addIngredientButton;
        private ListBox inventoryListBox;
        private Button backInventoryButton;
        private BindingSource ingredientBindingSource;
        private TextBox searchBox;
        private Button searchButton;
        private DateTimePicker dateTimePicker1;
    }
}