namespace Coursework.Forms
{
    partial class AddRecipe
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
            panel1 = new Panel();
            backButton = new Button();
            saveRecipeButton = new Button();
            ingredientsBox = new TextBox();
            label3 = new Label();
            recipeBox = new TextBox();
            label2 = new Label();
            nameBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(saveRecipeButton);
            panel1.Controls.Add(ingredientsBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(recipeBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 580);
            panel1.TabIndex = 0;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(64, 64, 64);
            backButton.Font = new Font("Segoe UI", 14F);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(617, 526);
            backButton.Name = "backButton";
            backButton.Size = new Size(204, 51);
            backButton.TabIndex = 7;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // saveRecipeButton
            // 
            saveRecipeButton.BackColor = Color.FromArgb(64, 64, 64);
            saveRecipeButton.Font = new Font("Segoe UI", 14F);
            saveRecipeButton.ForeColor = Color.White;
            saveRecipeButton.Location = new Point(301, 526);
            saveRecipeButton.Name = "saveRecipeButton";
            saveRecipeButton.Size = new Size(234, 51);
            saveRecipeButton.TabIndex = 6;
            saveRecipeButton.Text = "Зберегти рецепт";
            saveRecipeButton.UseVisualStyleBackColor = false;
            saveRecipeButton.Click += saveRecipeButton_Click;
            // 
            // ingredientsBox
            // 
            ingredientsBox.BackColor = Color.Silver;
            ingredientsBox.Font = new Font("Segoe UI", 14F);
            ingredientsBox.Location = new Point(112, 110);
            ingredientsBox.Multiline = true;
            ingredientsBox.Name = "ingredientsBox";
            ingredientsBox.Size = new Size(613, 95);
            ingredientsBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(301, 75);
            label3.Name = "label3";
            label3.Size = new Size(346, 32);
            label3.TabIndex = 4;
            label3.Text = "Введіть інгредієнти до страви:";
            // 
            // recipeBox
            // 
            recipeBox.BackColor = Color.Silver;
            recipeBox.Font = new Font("Segoe UI", 14F);
            recipeBox.Location = new Point(112, 256);
            recipeBox.MaxLength = 499;
            recipeBox.Multiline = true;
            recipeBox.Name = "recipeBox";
            recipeBox.Size = new Size(613, 249);
            recipeBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(301, 221);
            label2.Name = "label2";
            label2.Size = new Size(266, 32);
            label2.TabIndex = 2;
            label2.Text = "Введіть рецепт страви:";
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.Silver;
            nameBox.Font = new Font("Segoe UI", 14F);
            nameBox.Location = new Point(112, 31);
            nameBox.MaxLength = 49;
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(613, 39);
            nameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(301, -4);
            label1.Name = "label1";
            label1.Size = new Size(250, 32);
            label1.TabIndex = 0;
            label1.Text = "Введіть назву страви:";
            // 
            // AddRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(848, 604);
            Controls.Add(panel1);
            MaximumSize = new Size(866, 651);
            MinimumSize = new Size(866, 651);
            Name = "AddRecipe";
            Text = "AddRecipe";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private TextBox nameBox;
        private Label label1;
        private TextBox recipeBox;
        private Label label3;
        private TextBox ingredientsBox;
        private Button saveRecipeButton;
        private Button backButton;
    }
}