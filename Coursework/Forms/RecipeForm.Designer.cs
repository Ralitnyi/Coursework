namespace Coursework.Forms
{
    partial class RecipeForm
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
            descriptionBox = new TextBox();
            ingredientsBox = new TextBox();
            nameBox = new TextBox();
            backButton = new Button();
            recipeBindingSource1 = new BindingSource(components);
            recipeBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(descriptionBox);
            panel1.Controls.Add(ingredientsBox);
            panel1.Controls.Add(nameBox);
            panel1.Controls.Add(backButton);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(12, 12);
            panel1.MaximumSize = new Size(1135, 680);
            panel1.MinimumSize = new Size(1135, 680);
            panel1.Name = "panel1";
            panel1.Size = new Size(1135, 680);
            panel1.TabIndex = 0;
            // 
            // descriptionBox
            // 
            descriptionBox.BackColor = Color.Silver;
            descriptionBox.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            descriptionBox.Location = new Point(21, 244);
            descriptionBox.Multiline = true;
            descriptionBox.Name = "descriptionBox";
            descriptionBox.ReadOnly = true;
            descriptionBox.ScrollBars = ScrollBars.Vertical;
            descriptionBox.Size = new Size(1085, 346);
            descriptionBox.TabIndex = 6;
            // 
            // ingredientsBox
            // 
            ingredientsBox.BackColor = Color.Silver;
            ingredientsBox.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            ingredientsBox.Location = new Point(21, 92);
            ingredientsBox.Multiline = true;
            ingredientsBox.Name = "ingredientsBox";
            ingredientsBox.ReadOnly = true;
            ingredientsBox.ScrollBars = ScrollBars.Vertical;
            ingredientsBox.Size = new Size(1085, 121);
            ingredientsBox.TabIndex = 5;
            // 
            // nameBox
            // 
            nameBox.BackColor = Color.Silver;
            nameBox.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            nameBox.Location = new Point(309, 16);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(555, 52);
            nameBox.TabIndex = 4;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            backButton.BackColor = Color.FromArgb(64, 64, 64);
            backButton.Font = new Font("Segoe UI", 14F);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(987, 614);
            backButton.Name = "backButton";
            backButton.Size = new Size(145, 63);
            backButton.TabIndex = 3;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // recipeBindingSource1
            // 
            recipeBindingSource1.DataSource = typeof(Models.Recipe);
            // 
            // recipeBindingSource
            // 
            recipeBindingSource.DataSource = typeof(Models.Recipe);
            // 
            // RecipeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(1159, 704);
            Controls.Add(panel1);
            MaximumSize = new Size(1177, 751);
            MinimumSize = new Size(1177, 751);
            Name = "RecipeForm";
            Text = "RecipeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)recipeBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private BindingSource recipeBindingSource;
        private BindingSource recipeBindingSource1;
        private Button backButton;
        private TextBox descriptionBox;
        private TextBox ingredientsBox;
        private TextBox nameBox;
    }
}