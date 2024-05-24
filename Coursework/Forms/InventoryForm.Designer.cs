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
            panel1 = new Panel();
            countIngredientBox = new TextBox();
            timeIngredientBox = new TextBox();
            priceIngredientBox = new TextBox();
            nameIngredientBox = new TextBox();
            removeIngredientButton = new Button();
            addIngredientButton = new Button();
            inventoryListBox = new ListBox();
            backInventoryButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(backInventoryButton);
            panel1.Controls.Add(countIngredientBox);
            panel1.Controls.Add(timeIngredientBox);
            panel1.Controls.Add(priceIngredientBox);
            panel1.Controls.Add(nameIngredientBox);
            panel1.Controls.Add(removeIngredientButton);
            panel1.Controls.Add(addIngredientButton);
            panel1.Controls.Add(inventoryListBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(938, 562);
            panel1.TabIndex = 0;
            // 
            // countIngredientBox
            // 
            countIngredientBox.Location = new Point(774, 179);
            countIngredientBox.Name = "countIngredientBox";
            countIngredientBox.Size = new Size(161, 27);
            countIngredientBox.TabIndex = 6;
            // 
            // timeIngredientBox
            // 
            timeIngredientBox.Location = new Point(774, 232);
            timeIngredientBox.Name = "timeIngredientBox";
            timeIngredientBox.Size = new Size(161, 27);
            timeIngredientBox.TabIndex = 5;
            // 
            // priceIngredientBox
            // 
            priceIngredientBox.Location = new Point(774, 126);
            priceIngredientBox.Name = "priceIngredientBox";
            priceIngredientBox.Size = new Size(161, 27);
            priceIngredientBox.TabIndex = 4;
            // 
            // nameIngredientBox
            // 
            nameIngredientBox.Location = new Point(774, 75);
            nameIngredientBox.Name = "nameIngredientBox";
            nameIngredientBox.Size = new Size(161, 27);
            nameIngredientBox.TabIndex = 3;
            // 
            // removeIngredientButton
            // 
            removeIngredientButton.Location = new Point(633, 13);
            removeIngredientButton.Name = "removeIngredientButton";
            removeIngredientButton.Size = new Size(220, 48);
            removeIngredientButton.TabIndex = 2;
            removeIngredientButton.Text = "Видалити";
            removeIngredientButton.UseVisualStyleBackColor = true;
            // 
            // addIngredientButton
            // 
            addIngredientButton.Location = new Point(59, 13);
            addIngredientButton.Name = "addIngredientButton";
            addIngredientButton.Size = new Size(220, 48);
            addIngredientButton.TabIndex = 1;
            addIngredientButton.Text = "Додати";
            addIngredientButton.UseVisualStyleBackColor = true;
            // 
            // inventoryListBox
            // 
            inventoryListBox.FormattingEnabled = true;
            inventoryListBox.Location = new Point(3, 75);
            inventoryListBox.Name = "inventoryListBox";
            inventoryListBox.Size = new Size(756, 484);
            inventoryListBox.TabIndex = 0;
            // 
            // backInventoryButton
            // 
            backInventoryButton.Location = new Point(772, 485);
            backInventoryButton.Name = "backInventoryButton";
            backInventoryButton.Size = new Size(163, 74);
            backInventoryButton.TabIndex = 7;
            backInventoryButton.Text = "Назад";
            backInventoryButton.UseVisualStyleBackColor = true;
            backInventoryButton.Click += backInventoryButton_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 586);
            Controls.Add(panel1);
            Name = "InventoryForm";
            Text = "InventoryForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox countIngredientBox;
        private TextBox timeIngredientBox;
        private TextBox priceIngredientBox;
        private TextBox nameIngredientBox;
        private Button removeIngredientButton;
        private Button addIngredientButton;
        private ListBox inventoryListBox;
        private Button backInventoryButton;
    }
}