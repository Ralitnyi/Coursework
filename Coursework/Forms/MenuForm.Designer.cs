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
            panel1 = new Panel();
            label1 = new Label();
            recipeButton = new Button();
            inventoryButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(inventoryButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(recipeButton);
            panel1.Location = new Point(19, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(1046, 628);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(339, 129);
            label1.Name = "label1";
            label1.Size = new Size(266, 41);
            label1.TabIndex = 1;
            label1.Text = "Меню на сьогодні";
            // 
            // recipeButton
            // 
            recipeButton.Location = new Point(3, 3);
            recipeButton.Name = "recipeButton";
            recipeButton.Size = new Size(172, 95);
            recipeButton.TabIndex = 0;
            recipeButton.Text = "Рецепти";
            recipeButton.UseVisualStyleBackColor = true;
            recipeButton.Click += recipeButton_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.Location = new Point(398, 3);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(172, 95);
            inventoryButton.TabIndex = 2;
            inventoryButton.Text = "Склад";
            inventoryButton.UseVisualStyleBackColor = true;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 662);
            Controls.Add(panel1);
            Name = "MenuForm";
            Text = "Меню";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button recipeButton;
        private Label label1;
        private Button inventoryButton;
    }
}