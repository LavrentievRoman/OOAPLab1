namespace Lab1
{
    partial class FindNothingForm
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
            this.findNothingLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // findNothingLabel
            // 
            this.findNothingLabel.AutoSize = true;
            this.findNothingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findNothingLabel.Location = new System.Drawing.Point(12, 9);
            this.findNothingLabel.Name = "findNothingLabel";
            this.findNothingLabel.Size = new System.Drawing.Size(330, 20);
            this.findNothingLabel.TabIndex = 0;
            this.findNothingLabel.Text = "Товара с таким номером не найденно";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(123, 47);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(122, 32);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // FindNothingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 91);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.findNothingLabel);
            this.Name = "FindNothingForm";
            this.Text = "FindNothingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findNothingLabel;
        private System.Windows.Forms.Button okButton;
    }
}