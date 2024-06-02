namespace Coursework
{
    partial class RecipeBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeBookForm));
            panel1 = new Panel();
            newRecipeButton = new Button();
            recipeslistBox = new ListBox();
            recipeBindingSource2 = new BindingSource(components);
            label1 = new Label();
            panel2 = new Panel();
            descriptionTextBox = new TextBox();
            ingredientsTextBox = new TextBox();
            nameTextBox = new TextBox();
            removeButton = new Button();
            addButton = new Button();
            nameBox = new TextBox();
            backButton = new Button();
            searchPanel = new Panel();
            SearchButton = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource2).BeginInit();
            panel2.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(newRecipeButton);
            panel1.Controls.Add(recipeslistBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 674);
            panel1.TabIndex = 0;
            // 
            // newRecipeButton
            // 
            newRecipeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            newRecipeButton.BackColor = Color.FromArgb(64, 64, 64);
            newRecipeButton.Cursor = Cursors.Hand;
            newRecipeButton.Font = new Font("Segoe UI", 12F);
            newRecipeButton.ForeColor = Color.White;
            newRecipeButton.Location = new Point(0, 560);
            newRecipeButton.Name = "newRecipeButton";
            newRecipeButton.Size = new Size(158, 67);
            newRecipeButton.TabIndex = 3;
            newRecipeButton.Text = "Новий рецепт";
            newRecipeButton.UseVisualStyleBackColor = false;
            newRecipeButton.Click += newRecipeButton_Click;
            // 
            // recipeslistBox
            // 
            recipeslistBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recipeslistBox.BackColor = Color.Gray;
            recipeslistBox.DataSource = recipeBindingSource2;
            recipeslistBox.DisplayMember = "Name";
            recipeslistBox.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            recipeslistBox.ForeColor = Color.Black;
            recipeslistBox.FormattingEnabled = true;
            recipeslistBox.ItemHeight = 31;
            recipeslistBox.Location = new Point(0, 58);
            recipeslistBox.Name = "recipeslistBox";
            recipeslistBox.Size = new Size(310, 469);
            recipeslistBox.TabIndex = 1;
            recipeslistBox.ValueMember = "Id";
            recipeslistBox.DoubleClick += recipeslistBox_DobleClick;
            // 
            // recipeBindingSource2
            // 
            recipeBindingSource2.DataSource = typeof(Models.Recipe);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(0, -3);
            label1.Name = "label1";
            label1.Size = new Size(155, 46);
            label1.TabIndex = 0;
            label1.Text = "Рецепти";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel2.BackColor = Color.Gray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(descriptionTextBox);
            panel2.Controls.Add(ingredientsTextBox);
            panel2.Controls.Add(nameTextBox);
            panel2.Controls.Add(removeButton);
            panel2.Location = new Point(443, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 432);
            panel2.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            descriptionTextBox.BackColor = Color.Silver;
            descriptionTextBox.DataBindings.Add(new Binding("Text", recipeBindingSource2, "Description", true));
            descriptionTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            descriptionTextBox.ForeColor = Color.Black;
            descriptionTextBox.Location = new Point(16, 233);
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ReadOnly = true;
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(669, 176);
            descriptionTextBox.TabIndex = 11;
            // 
            // ingredientsTextBox
            // 
            ingredientsTextBox.Anchor = AnchorStyles.Right;
            ingredientsTextBox.BackColor = Color.Silver;
            ingredientsTextBox.DataBindings.Add(new Binding("Text", recipeBindingSource2, "IngredientsAsString", true));
            ingredientsTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold);
            ingredientsTextBox.ForeColor = Color.Black;
            ingredientsTextBox.Location = new Point(16, 88);
            ingredientsTextBox.Multiline = true;
            ingredientsTextBox.Name = "ingredientsTextBox";
            ingredientsTextBox.ReadOnly = true;
            ingredientsTextBox.ScrollBars = ScrollBars.Vertical;
            ingredientsTextBox.Size = new Size(538, 106);
            ingredientsTextBox.TabIndex = 10;
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameTextBox.BackColor = Color.Silver;
            nameTextBox.DataBindings.Add(new Binding("Text", recipeBindingSource2, "Name", true));
            nameTextBox.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            nameTextBox.ForeColor = Color.Black;
            nameTextBox.Location = new Point(16, 17);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(538, 43);
            nameTextBox.TabIndex = 4;
            // 
            // removeButton
            // 
            removeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            removeButton.Cursor = Cursors.Hand;
            removeButton.Image = (Image)resources.GetObject("removeButton.Image");
            removeButton.Location = new Point(606, 17);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(79, 74);
            removeButton.TabIndex = 9;
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.BackColor = Color.FromArgb(64, 64, 64);
            addButton.Cursor = Cursors.Hand;
            addButton.Font = new Font("Segoe UI", 14F);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(443, 571);
            addButton.Name = "addButton";
            addButton.Size = new Size(226, 67);
            addButton.TabIndex = 8;
            addButton.Text = "Додати до меню";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click_1;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nameBox.BackColor = Color.Silver;
            nameBox.Cursor = Cursors.IBeam;
            nameBox.Font = new Font("Segoe UI", 14F);
            nameBox.ForeColor = Color.Black;
            nameBox.Location = new Point(174, 10);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(339, 39);
            nameBox.TabIndex = 2;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = Color.FromArgb(64, 64, 64);
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Segoe UI", 12F);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(989, 572);
            backButton.Name = "backButton";
            backButton.Size = new Size(158, 67);
            backButton.TabIndex = 2;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // searchPanel
            // 
            searchPanel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchPanel.Controls.Add(SearchButton);
            searchPanel.Controls.Add(nameBox);
            searchPanel.Controls.Add(label2);
            searchPanel.Location = new Point(377, 9);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(661, 61);
            searchPanel.TabIndex = 4;
            // 
            // SearchButton
            // 
            SearchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SearchButton.BackColor = Color.FromArgb(64, 64, 64);
            SearchButton.Cursor = Cursors.Hand;
            SearchButton.Font = new Font("Segoe UI", 12F);
            SearchButton.ForeColor = Color.White;
            SearchButton.Location = new Point(526, 10);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(95, 39);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 13);
            label2.Name = "label2";
            label2.Size = new Size(166, 31);
            label2.TabIndex = 1;
            label2.Text = "Назва страви:";
            // 
            // RecipeBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1159, 704);
            Controls.Add(backButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(addButton);
            Controls.Add(searchPanel);
            MinimumSize = new Size(1177, 751);
            Name = "RecipeBookForm";
            Text = "Книга рецептів";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox recipeslistBox;
        private Label label1;
        private Panel panel2;
        private Button backButton;
        private Button addButton;
        private Button newRecipeButton;
        private BindingSource recipeBindingSource2;
        private Panel searchPanel;
        private Button SearchButton;
        private TextBox nameBox;
        private Label label2;
        private Button removeButton;
        private TextBox descriptionTextBox;
        private TextBox ingredientsTextBox;
        private TextBox nameTextBox;
    }
}