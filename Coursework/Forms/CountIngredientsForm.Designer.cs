namespace Coursework.Forms
{
    partial class CountIngredientsForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            saveButton = new Button();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            flowLayoutPanel1.Location = new Point(12, 8);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(776, 359);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // saveButton
            // 
            saveButton.BackColor = Color.FromArgb(64, 64, 64);
            saveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(663, 389);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(125, 49);
            saveButton.TabIndex = 0;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // CountIngredientsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DimGray;
            ClientSize = new Size(800, 450);
            Controls.Add(saveButton);
            Controls.Add(flowLayoutPanel1);
            Name = "CountIngredientsForm";
            Text = "Введіть кількість інгредієнтів";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button saveButton;
    }
}