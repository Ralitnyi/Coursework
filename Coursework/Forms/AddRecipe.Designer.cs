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
            panel1.Controls.Add(saveRecipeButton);
            panel1.Controls.Add(ingredientsBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(recipeBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 563);
            panel1.TabIndex = 0;
            // 
            // saveRecipeButton
            // 
            saveRecipeButton.Font = new Font("Segoe UI", 12F);
            saveRecipeButton.Location = new Point(292, 526);
            saveRecipeButton.Name = "saveRecipeButton";
            saveRecipeButton.Size = new Size(262, 34);
            saveRecipeButton.TabIndex = 6;
            saveRecipeButton.Text = "Зберегти рецепт";
            saveRecipeButton.UseVisualStyleBackColor = true;
            saveRecipeButton.Click += saveRecipeButton_Click;
            // 
            // ingredientsBox
            // 
            ingredientsBox.Font = new Font("Segoe UI", 12F);
            ingredientsBox.Location = new Point(112, 110);
            ingredientsBox.Multiline = true;
            ingredientsBox.Name = "ingredientsBox";
            ingredientsBox.Size = new Size(613, 95);
            ingredientsBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(301, 79);
            label3.Name = "label3";
            label3.Size = new Size(286, 28);
            label3.TabIndex = 4;
            label3.Text = "Введіть інгредієнти до страви:";
            // 
            // recipeBox
            // 
            recipeBox.Font = new Font("Segoe UI", 12F);
            recipeBox.Location = new Point(112, 256);
            recipeBox.Multiline = true;
            recipeBox.Name = "recipeBox";
            recipeBox.Size = new Size(613, 249);
            recipeBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(301, 225);
            label2.Name = "label2";
            label2.Size = new Size(218, 28);
            label2.TabIndex = 2;
            label2.Text = "Введіть рецепт страви:";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(112, 31);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(613, 34);
            nameBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(301, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 28);
            label1.TabIndex = 0;
            label1.Text = "Введіть назву страви:";
            // 
            // AddRecipe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 587);
            Controls.Add(panel1);
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
    }
}