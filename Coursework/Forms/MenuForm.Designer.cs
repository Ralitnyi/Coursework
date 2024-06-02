namespace Coursework.Forms
{
    partial class MenuForm
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
            dailyRecipeBox = new TextBox();
            dailyRecipeButton = new Button();
            extractButton = new Button();
            removeAllButton = new Button();
            removeButton = new Button();
            menuListBox = new ListBox();
            recipeBindingSource = new BindingSource(components);
            inventoryButton = new Button();
            label1 = new Label();
            recipeButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dailyRecipeBox);
            panel1.Controls.Add(dailyRecipeButton);
            panel1.Controls.Add(extractButton);
            panel1.Controls.Add(removeAllButton);
            panel1.Controls.Add(removeButton);
            panel1.Controls.Add(menuListBox);
            panel1.Controls.Add(inventoryButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(recipeButton);
            panel1.Location = new Point(1, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 670);
            panel1.TabIndex = 0;
            // 
            // dailyRecipeBox
            // 
            dailyRecipeBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dailyRecipeBox.BackColor = Color.Gray;
            dailyRecipeBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dailyRecipeBox.Location = new Point(790, 18);
            dailyRecipeBox.Name = "dailyRecipeBox";
            dailyRecipeBox.ReadOnly = true;
            dailyRecipeBox.ShortcutsEnabled = false;
            dailyRecipeBox.Size = new Size(342, 43);
            dailyRecipeBox.TabIndex = 8;
            dailyRecipeBox.DoubleClick += dailyRecipeBox_DoubleClick;
            // 
            // dailyRecipeButton
            // 
            dailyRecipeButton.Anchor = AnchorStyles.Top;
            dailyRecipeButton.BackColor = Color.FromArgb(64, 64, 64);
            dailyRecipeButton.Cursor = Cursors.Hand;
            dailyRecipeButton.Font = new Font("Segoe UI", 16F);
            dailyRecipeButton.ForeColor = Color.White;
            dailyRecipeButton.Location = new Point(587, 0);
            dailyRecipeButton.Name = "dailyRecipeButton";
            dailyRecipeButton.Size = new Size(172, 79);
            dailyRecipeButton.TabIndex = 7;
            dailyRecipeButton.Text = "Страва дня";
            dailyRecipeButton.UseVisualStyleBackColor = false;
            dailyRecipeButton.Click += dailyRecipeButton_Click;
            // 
            // extractButton
            // 
            extractButton.Anchor = AnchorStyles.Top;
            extractButton.BackColor = Color.FromArgb(64, 64, 64);
            extractButton.Cursor = Cursors.Hand;
            extractButton.Font = new Font("Segoe UI", 16F);
            extractButton.ForeColor = Color.White;
            extractButton.Location = new Point(393, 0);
            extractButton.Name = "extractButton";
            extractButton.Size = new Size(172, 79);
            extractButton.TabIndex = 6;
            extractButton.Text = "Виписка";
            extractButton.UseVisualStyleBackColor = false;
            extractButton.Click += extractButton_Click;
            // 
            // removeAllButton
            // 
            removeAllButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeAllButton.BackColor = Color.FromArgb(64, 64, 64);
            removeAllButton.Cursor = Cursors.Hand;
            removeAllButton.Font = new Font("Segoe UI", 12F);
            removeAllButton.ForeColor = Color.White;
            removeAllButton.Location = new Point(975, 111);
            removeAllButton.Name = "removeAllButton";
            removeAllButton.Size = new Size(157, 57);
            removeAllButton.TabIndex = 5;
            removeAllButton.Text = "Видалити Все";
            removeAllButton.UseVisualStyleBackColor = false;
            removeAllButton.Click += removeAllButton_Click;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeButton.BackColor = Color.FromArgb(64, 64, 64);
            removeButton.Cursor = Cursors.Hand;
            removeButton.Font = new Font("Segoe UI", 12F);
            removeButton.ForeColor = Color.White;
            removeButton.Location = new Point(790, 111);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(157, 57);
            removeButton.TabIndex = 4;
            removeButton.Text = "Видалити";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // menuListBox
            // 
            menuListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            menuListBox.BackColor = Color.Gray;
            menuListBox.ColumnWidth = 400;
            menuListBox.DataSource = recipeBindingSource;
            menuListBox.DisplayMember = "Name";
            menuListBox.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            menuListBox.ForeColor = Color.Black;
            menuListBox.FormattingEnabled = true;
            menuListBox.ItemHeight = 41;
            menuListBox.Location = new Point(18, 174);
            menuListBox.MultiColumn = true;
            menuListBox.Name = "menuListBox";
            menuListBox.Size = new Size(1114, 455);
            menuListBox.TabIndex = 3;
            menuListBox.ValueMember = "Id";
            menuListBox.DoubleClick += menuListBox_DoubleClick;
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Models.Recipe);
            // 
            // inventoryButton
            // 
            inventoryButton.Anchor = AnchorStyles.Top;
            inventoryButton.BackColor = Color.FromArgb(64, 64, 64);
            inventoryButton.Cursor = Cursors.Hand;
            inventoryButton.Font = new Font("Segoe UI", 16F);
            inventoryButton.ForeColor = Color.White;
            inventoryButton.Location = new Point(199, 0);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(172, 79);
            inventoryButton.TabIndex = 2;
            inventoryButton.Text = "Склад";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(18, 122);
            label1.Name = "label1";
            label1.Size = new Size(322, 46);
            label1.TabIndex = 1;
            label1.Text = "Меню на сьогодні";
            // 
            // recipeButton
            // 
            recipeButton.Anchor = AnchorStyles.Top;
            recipeButton.BackColor = Color.FromArgb(64, 64, 64);
            recipeButton.Cursor = Cursors.Hand;
            recipeButton.Font = new Font("Segoe UI", 16F);
            recipeButton.ForeColor = Color.White;
            recipeButton.Location = new Point(4, 0);
            recipeButton.Name = "recipeButton";
            recipeButton.Size = new Size(172, 79);
            recipeButton.TabIndex = 0;
            recipeButton.Text = "Рецепти";
            recipeButton.UseVisualStyleBackColor = false;
            recipeButton.Click += recipeButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1159, 704);
            Controls.Add(panel1);
            MinimumSize = new Size(1177, 751);
            Name = "MenuForm";
            Text = "Меню";
            Load += MenuForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button recipeButton;
        private Label label1;
        private Button inventoryButton;
        private BindingSource recipeBindingSource;
        private ListBox menuListBox;
        private Button removeAllButton;
        private Button removeButton;
        private Button extractButton;
        private Button dailyRecipeButton;
        private TextBox dailyRecipeBox;
    }
}