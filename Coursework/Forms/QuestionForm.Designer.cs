namespace Coursework.Forms
{
    partial class QuestionForm
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
            okButton = new Button();
            backButton = new Button();
            textBox = new TextBox();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.BackColor = Color.FromArgb(64, 64, 64);
            okButton.Font = new Font("Segoe UI", 14F);
            okButton.ForeColor = Color.White;
            okButton.Location = new Point(143, 237);
            okButton.Name = "okButton";
            okButton.Size = new Size(241, 52);
            okButton.TabIndex = 0;
            okButton.Text = "Додати інгредієнти";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(64, 64, 64);
            backButton.Font = new Font("Segoe UI", 14F);
            backButton.ForeColor = Color.White;
            backButton.Location = new Point(406, 237);
            backButton.Name = "backButton";
            backButton.Size = new Size(241, 52);
            backButton.TabIndex = 1;
            backButton.Text = "Пропустити";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // textBox
            // 
            textBox.BackColor = Color.FromArgb(224, 224, 224);
            textBox.Font = new Font("Segoe UI", 12F);
            textBox.ForeColor = Color.Black;
            textBox.Location = new Point(10, 12);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(637, 205);
            textBox.TabIndex = 2;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(659, 311);
            Controls.Add(textBox);
            Controls.Add(backButton);
            Controls.Add(okButton);
            Name = "QuestionForm";
            Text = "Не вистачає інгредієнтів на складі";
            Load += QuestionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Button backButton;
        private TextBox textBox;
    }
}