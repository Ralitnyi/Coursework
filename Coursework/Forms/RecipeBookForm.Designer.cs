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
            panel1 = new Panel();
            recipeslistBox = new ListBox();
            recipeBindingSource2 = new BindingSource(components);
            label1 = new Label();
            panel2 = new Panel();
            addButton = new Button();
            editButton = new Button();
            ingredientsBox = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            backButton = new Button();
            newRecipeButton = new Button();
            searchPanel = new Panel();
            SearchButton = new Button();
            nameBox = new TextBox();
            label2 = new Label();
            removeButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource2).BeginInit();
            panel2.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(recipeslistBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 533);
            panel1.TabIndex = 0;
            // 
            // recipeslistBox
            // 
            recipeslistBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            recipeslistBox.DataSource = recipeBindingSource2;
            recipeslistBox.DisplayMember = "Name";
            recipeslistBox.FormattingEnabled = true;
            recipeslistBox.Location = new Point(0, 43);
            recipeslistBox.Name = "recipeslistBox";
            recipeslistBox.Size = new Size(321, 484);
            recipeslistBox.TabIndex = 1;
            recipeslistBox.ValueMember = "Id";
            recipeslistBox.SelectedIndexChanged += recipeslistBox_SelectedIndexChanged;
            // 
            // recipeBindingSource2
            // 
            recipeBindingSource2.DataSource = typeof(Models.Recipe);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 41);
            label1.TabIndex = 0;
            label1.Text = "Рецепти";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(removeButton);
            panel2.Controls.Add(addButton);
            panel2.Controls.Add(editButton);
            panel2.Controls.Add(ingredientsBox);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(375, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(704, 432);
            panel2.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Location = new Point(527, 55);
            addButton.Name = "addButton";
            addButton.Size = new Size(94, 60);
            addButton.TabIndex = 8;
            addButton.Text = "Додати до меню";
            addButton.UseVisualStyleBackColor = true;
            // 
            // editButton
            // 
            editButton.Location = new Point(418, 55);
            editButton.Name = "editButton";
            editButton.Size = new Size(103, 60);
            editButton.TabIndex = 7;
            editButton.Text = "Редагувати";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // ingredientsBox
            // 
            ingredientsBox.DataBindings.Add(new Binding("Text", recipeBindingSource2, "IngredientsAsString", true));
            ingredientsBox.Location = new Point(3, 49);
            ingredientsBox.Multiline = true;
            ingredientsBox.Name = "ingredientsBox";
            ingredientsBox.Size = new Size(391, 76);
            ingredientsBox.TabIndex = 6;
            ingredientsBox.TextChanged += ingredientsBox_TextChanged;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", recipeBindingSource2, "Description", true));
            textBox2.Location = new Point(5, 131);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(694, 296);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.DataBindings.Add(new Binding("Text", recipeBindingSource2, "Name", true));
            textBox1.Location = new Point(5, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(391, 27);
            textBox1.TabIndex = 3;
            // 
            // backButton
            // 
            backButton.Location = new Point(932, 562);
            backButton.Name = "backButton";
            backButton.Size = new Size(147, 67);
            backButton.TabIndex = 2;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // newRecipeButton
            // 
            newRecipeButton.Location = new Point(12, 562);
            newRecipeButton.Name = "newRecipeButton";
            newRecipeButton.Size = new Size(147, 67);
            newRecipeButton.TabIndex = 3;
            newRecipeButton.Text = "Новий рецепт";
            newRecipeButton.UseVisualStyleBackColor = true;
            newRecipeButton.Click += newRecipeButton_Click;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(SearchButton);
            searchPanel.Controls.Add(nameBox);
            searchPanel.Controls.Add(label2);
            searchPanel.Location = new Point(377, 9);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(565, 61);
            searchPanel.TabIndex = 4;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(474, 12);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(71, 41);
            SearchButton.TabIndex = 3;
            SearchButton.Text = "Пошук";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click_1;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(129, 19);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(339, 27);
            nameBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 19);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Назва страви:";
            // 
            // removeButton
            // 
            removeButton.Image = Properties.Resources.trash_icon;
            removeButton.Location = new Point(627, 55);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(58, 60);
            removeButton.TabIndex = 9;
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // RecipeBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 641);
            Controls.Add(newRecipeButton);
            Controls.Add(backButton);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(searchPanel);
            Name = "RecipeBookForm";
            Text = "Книга рецептів";
            Load += RecipeBookForm_Load;
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
        private TextBox textBox1;
        private TextBox textBox2;
        private Button backButton;
        private Button addButton;
        private Button newRecipeButton;
        private BindingSource recipeBindingSource2;
        private TextBox ingredientsBox;
        private Panel searchPanel;
        private Button SearchButton;
        private TextBox nameBox;
        private Label label2;
        private Button editButton;
        private Button removeButton;
    }
}