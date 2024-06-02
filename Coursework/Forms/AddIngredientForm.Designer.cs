namespace Coursework.Forms
{
    partial class AddIngredientForm
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
            saveButton = new Button();
            backButton = new Button();
            dateTimePicker = new DateTimePicker();
            priceBox = new TextBox();
            countBox = new TextBox();
            nameBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(saveButton);
            panel1.Controls.Add(backButton);
            panel1.Controls.Add(dateTimePicker);
            panel1.Controls.Add(priceBox);
            panel1.Controls.Add(countBox);
            panel1.Controls.Add(nameBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(643, 324);
            panel1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            saveButton.BackColor = Color.FromArgb(64, 64, 64);
            saveButton.Font = new Font("Segoe UI", 14F);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(376, 276);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(121, 45);
            saveButton.TabIndex = 5;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // backButton
            // 
            backButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            backButton.BackColor = Color.FromArgb(64, 64, 64);
            backButton.Font = new Font("Segoe UI", 14F);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(519, 276);
            backButton.Name = "backButton";
            backButton.Size = new Size(121, 45);
            backButton.TabIndex = 4;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker.CalendarFont = new Font("Segoe UI", 12F);
            dateTimePicker.Location = new Point(185, 223);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(254, 27);
            dateTimePicker.TabIndex = 3;
            // 
            // priceBox
            // 
            priceBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            priceBox.BackColor = Color.Silver;
            priceBox.Font = new Font("Segoe UI", 12F);
            priceBox.Location = new Point(185, 150);
            priceBox.MaxLength = 9;
            priceBox.Name = "priceBox";
            priceBox.PlaceholderText = "Ціна:";
            priceBox.Size = new Size(252, 34);
            priceBox.TabIndex = 2;
            // 
            // countBox
            // 
            countBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            countBox.BackColor = Color.Silver;
            countBox.Font = new Font("Segoe UI", 12F);
            countBox.Location = new Point(185, 78);
            countBox.MaxLength = 6;
            countBox.Name = "countBox";
            countBox.PlaceholderText = "Кількість:";
            countBox.Size = new Size(252, 34);
            countBox.TabIndex = 1;
            // 
            // nameBox
            // 
            nameBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            nameBox.BackColor = Color.Silver;
            nameBox.Font = new Font("Segoe UI", 12F);
            nameBox.Location = new Point(185, 15);
            nameBox.MaxLength = 49;
            nameBox.Name = "nameBox";
            nameBox.PlaceholderText = "Назва:";
            nameBox.Size = new Size(252, 34);
            nameBox.TabIndex = 0;
            // 
            // AddIngredientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(667, 348);
            Controls.Add(panel1);
            MaximumSize = new Size(685, 395);
            MinimumSize = new Size(685, 395);
            Name = "AddIngredientForm";
            Text = "Новий інгредієнт";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button saveButton;
        private Button backButton;
        private DateTimePicker dateTimePicker;
        private TextBox priceBox;
        private TextBox countBox;
        private TextBox nameBox;
    }
}