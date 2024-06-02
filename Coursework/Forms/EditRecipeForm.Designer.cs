namespace Coursework.Forms
{
    partial class EditRecipeForm
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
            saveButton = new Button();
            descriptionTextBox = new TextBox();
            ingredientsTextBox = new TextBox();
            nameTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(descriptionTextBox);
            panel1.Controls.Add(ingredientsTextBox);
            panel1.Controls.Add(nameTextBox);
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
            backButton.Location = new Point(620, 495);
            backButton.Name = "backButton";
            backButton.Size = new Size(152, 68);
            backButton.TabIndex = 4;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(64, 64, 64);
            saveButton.Font = new Font("Segoe UI", 14F);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(439, 495);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(147, 68);
            saveButton.TabIndex = 3;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.BackColor = Color.Silver;
            descriptionTextBox.Font = new Font("Segoe UI", 14F);
            descriptionTextBox.Location = new Point(56, 229);
            descriptionTextBox.MaxLength = 499;
            descriptionTextBox.Multiline = true;
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.ScrollBars = ScrollBars.Vertical;
            descriptionTextBox.Size = new Size(716, 239);
            descriptionTextBox.TabIndex = 2;
            // 
            // ingredientsTextBox
            // 
            ingredientsTextBox.BackColor = Color.Silver;
            ingredientsTextBox.Font = new Font("Segoe UI", 14F);
            ingredientsTextBox.Location = new Point(178, 94);
            ingredientsTextBox.Multiline = true;
            ingredientsTextBox.Name = "ingredientsTextBox";
            ingredientsTextBox.ScrollBars = ScrollBars.Vertical;
            ingredientsTextBox.Size = new Size(452, 112);
            ingredientsTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.Silver;
            nameTextBox.Font = new Font("Segoe UI", 14F);
            nameTextBox.Location = new Point(235, 19);
            nameTextBox.MaxLength = 49;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(351, 39);
            nameTextBox.TabIndex = 0;
            // 
            // EditRecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(848, 604);
            Controls.Add(panel1);
            MaximumSize = new Size(866, 651);
            MinimumSize = new Size(866, 651);
            Name = "EditRecipeForm";
            Text = "Редагувати рецепт";
            Load += EditRecipeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox nameTextBox;
        private TextBox descriptionTextBox;
        private TextBox ingredientsTextBox;
        private Button backButton;
        private Button saveButton;
    }
}