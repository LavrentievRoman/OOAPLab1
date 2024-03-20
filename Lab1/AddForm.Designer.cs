namespace Lab1
{
    partial class AddForm
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
            this.askLabel = new System.Windows.Forms.Label();
            this.addMotherBoardButton = new System.Windows.Forms.Button();
            this.addProcessorButton = new System.Windows.Forms.Button();
            this.AddHardDiskButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // askLabel
            // 
            this.askLabel.AutoSize = true;
            this.askLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.askLabel.Location = new System.Drawing.Point(45, 18);
            this.askLabel.Name = "askLabel";
            this.askLabel.Size = new System.Drawing.Size(407, 25);
            this.askLabel.TabIndex = 0;
            this.askLabel.Text = "Какой продукт вы хотите добавить?";
            // 
            // addMotherBoardButton
            // 
            this.addMotherBoardButton.Location = new System.Drawing.Point(38, 91);
            this.addMotherBoardButton.Name = "addMotherBoardButton";
            this.addMotherBoardButton.Size = new System.Drawing.Size(133, 41);
            this.addMotherBoardButton.TabIndex = 1;
            this.addMotherBoardButton.Text = "Материнская плата";
            this.addMotherBoardButton.UseVisualStyleBackColor = true;
            this.addMotherBoardButton.Click += new System.EventHandler(this.addMotherBoardButton_Click);
            // 
            // addProcessorButton
            // 
            this.addProcessorButton.Location = new System.Drawing.Point(177, 91);
            this.addProcessorButton.Name = "addProcessorButton";
            this.addProcessorButton.Size = new System.Drawing.Size(133, 41);
            this.addProcessorButton.TabIndex = 2;
            this.addProcessorButton.Text = "Процессор";
            this.addProcessorButton.UseVisualStyleBackColor = true;
            this.addProcessorButton.Click += new System.EventHandler(this.addProcessorButton_Click);
            // 
            // AddHardDiskButton
            // 
            this.AddHardDiskButton.Location = new System.Drawing.Point(316, 91);
            this.AddHardDiskButton.Name = "AddHardDiskButton";
            this.AddHardDiskButton.Size = new System.Drawing.Size(133, 41);
            this.AddHardDiskButton.TabIndex = 3;
            this.AddHardDiskButton.Text = "Жёсткий диск";
            this.AddHardDiskButton.UseVisualStyleBackColor = true;
            this.AddHardDiskButton.Click += new System.EventHandler(this.AddHardDiskButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 192);
            this.Controls.Add(this.AddHardDiskButton);
            this.Controls.Add(this.addProcessorButton);
            this.Controls.Add(this.addMotherBoardButton);
            this.Controls.Add(this.askLabel);
            this.Name = "AddForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label askLabel;
        private System.Windows.Forms.Button addMotherBoardButton;
        private System.Windows.Forms.Button addProcessorButton;
        private System.Windows.Forms.Button AddHardDiskButton;
    }
}