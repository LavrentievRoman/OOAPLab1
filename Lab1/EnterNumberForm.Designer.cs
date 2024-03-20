namespace Lab1
{
    partial class EnterNumberForm
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
            this.enterNumberLabel = new System.Windows.Forms.Label();
            this.enterNumberTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // enterNumberLabel
            // 
            this.enterNumberLabel.AutoSize = true;
            this.enterNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterNumberLabel.Location = new System.Drawing.Point(71, 19);
            this.enterNumberLabel.Name = "enterNumberLabel";
            this.enterNumberLabel.Size = new System.Drawing.Size(140, 20);
            this.enterNumberLabel.TabIndex = 0;
            this.enterNumberLabel.Text = "Введите номер";
            // 
            // enterNumberTextBox
            // 
            this.enterNumberTextBox.Location = new System.Drawing.Point(57, 56);
            this.enterNumberTextBox.Name = "enterNumberTextBox";
            this.enterNumberTextBox.Size = new System.Drawing.Size(169, 20);
            this.enterNumberTextBox.TabIndex = 1;
            this.enterNumberTextBox.Text = "1000000";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(75, 95);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(120, 42);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Найти";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // EnterNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 149);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.enterNumberTextBox);
            this.Controls.Add(this.enterNumberLabel);
            this.Name = "EnterNumberForm";
            this.Text = "EnterNumberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterNumberLabel;
        public System.Windows.Forms.TextBox enterNumberTextBox;
        private System.Windows.Forms.Button FindButton;
    }
}