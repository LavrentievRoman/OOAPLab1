namespace Lab1
{
    partial class FindProcessorForm
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
            this.coreNumberNum = new System.Windows.Forms.NumericUpDown();
            this.coresNumberLabel = new System.Windows.Forms.Label();
            this.socketTypeComboBox = new System.Windows.Forms.ComboBox();
            this.clockFrequenceNum = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberNum = new System.Windows.Forms.NumericUpDown();
            this.clockFrequenceLabel = new System.Windows.Forms.Label();
            this.socketTypeLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.addProcessorLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coreNumberNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockFrequenceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // coreNumberNum
            // 
            this.coreNumberNum.Enabled = false;
            this.coreNumberNum.Location = new System.Drawing.Point(197, 194);
            this.coreNumberNum.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.coreNumberNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coreNumberNum.Name = "coreNumberNum";
            this.coreNumberNum.Size = new System.Drawing.Size(53, 20);
            this.coreNumberNum.TabIndex = 60;
            this.coreNumberNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // coresNumberLabel
            // 
            this.coresNumberLabel.AutoSize = true;
            this.coresNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coresNumberLabel.Location = new System.Drawing.Point(17, 194);
            this.coresNumberLabel.Name = "coresNumberLabel";
            this.coresNumberLabel.Size = new System.Drawing.Size(122, 16);
            this.coresNumberLabel.TabIndex = 59;
            this.coresNumberLabel.Text = "Количество ядер:";
            // 
            // socketTypeComboBox
            // 
            this.socketTypeComboBox.Enabled = false;
            this.socketTypeComboBox.FormattingEnabled = true;
            this.socketTypeComboBox.Items.AddRange(new object[] {
            "LGA 775",
            "LGA 1156",
            "LGA 1366",
            "LGA 2011",
            "AM2",
            "AM2+",
            "AM3",
            "AM3+",
            "FM1"});
            this.socketTypeComboBox.Location = new System.Drawing.Point(197, 160);
            this.socketTypeComboBox.Name = "socketTypeComboBox";
            this.socketTypeComboBox.Size = new System.Drawing.Size(93, 21);
            this.socketTypeComboBox.TabIndex = 58;
            // 
            // clockFrequenceNum
            // 
            this.clockFrequenceNum.DecimalPlaces = 2;
            this.clockFrequenceNum.Enabled = false;
            this.clockFrequenceNum.Location = new System.Drawing.Point(197, 228);
            this.clockFrequenceNum.Name = "clockFrequenceNum";
            this.clockFrequenceNum.Size = new System.Drawing.Size(120, 20);
            this.clockFrequenceNum.TabIndex = 57;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(197, 89);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 20);
            this.nameTextBox.TabIndex = 56;
            this.nameTextBox.Text = "ывыв";
            // 
            // numberNum
            // 
            this.numberNum.Enabled = false;
            this.numberNum.Location = new System.Drawing.Point(197, 56);
            this.numberNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numberNum.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numberNum.Name = "numberNum";
            this.numberNum.Size = new System.Drawing.Size(268, 20);
            this.numberNum.TabIndex = 55;
            this.numberNum.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // clockFrequenceLabel
            // 
            this.clockFrequenceLabel.AutoSize = true;
            this.clockFrequenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clockFrequenceLabel.Location = new System.Drawing.Point(17, 228);
            this.clockFrequenceLabel.Name = "clockFrequenceLabel";
            this.clockFrequenceLabel.Size = new System.Drawing.Size(128, 16);
            this.clockFrequenceLabel.TabIndex = 54;
            this.clockFrequenceLabel.Text = "Тактовая чатсота:";
            // 
            // socketTypeLabel
            // 
            this.socketTypeLabel.AutoSize = true;
            this.socketTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.socketTypeLabel.Location = new System.Drawing.Point(17, 160);
            this.socketTypeLabel.Name = "socketTypeLabel";
            this.socketTypeLabel.Size = new System.Drawing.Size(83, 16);
            this.socketTypeLabel.TabIndex = 53;
            this.socketTypeLabel.Text = "Тип сокета:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(17, 60);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(53, 16);
            this.numberLabel.TabIndex = 52;
            this.numberLabel.Text = "Номер:";
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Enabled = false;
            this.priceNum.Location = new System.Drawing.Point(197, 125);
            this.priceNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(144, 20);
            this.priceNum.TabIndex = 51;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(17, 125);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 16);
            this.priceLabel.TabIndex = 50;
            this.priceLabel.Text = "Цена:";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(17, 90);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(76, 16);
            this.textLabel.TabIndex = 49;
            this.textLabel.Text = "Название:";
            // 
            // addProcessorLabel
            // 
            this.addProcessorLabel.AutoSize = true;
            this.addProcessorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProcessorLabel.Location = new System.Drawing.Point(182, 9);
            this.addProcessorLabel.Name = "addProcessorLabel";
            this.addProcessorLabel.Size = new System.Drawing.Size(118, 24);
            this.addProcessorLabel.TabIndex = 48;
            this.addProcessorLabel.Text = "Процессор";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(313, 288);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(152, 46);
            this.closeButton.TabIndex = 61;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // FindProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 371);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.coreNumberNum);
            this.Controls.Add(this.coresNumberLabel);
            this.Controls.Add(this.socketTypeComboBox);
            this.Controls.Add(this.clockFrequenceNum);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberNum);
            this.Controls.Add(this.clockFrequenceLabel);
            this.Controls.Add(this.socketTypeLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.addProcessorLabel);
            this.Name = "FindProcessorForm";
            this.Text = "FindProcessorForm";
            ((System.ComponentModel.ISupportInitialize)(this.coreNumberNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockFrequenceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown coreNumberNum;
        public System.Windows.Forms.Label coresNumberLabel;
        public System.Windows.Forms.ComboBox socketTypeComboBox;
        public System.Windows.Forms.NumericUpDown clockFrequenceNum;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.NumericUpDown numberNum;
        public System.Windows.Forms.Label clockFrequenceLabel;
        public System.Windows.Forms.Label socketTypeLabel;
        public System.Windows.Forms.Label numberLabel;
        public System.Windows.Forms.NumericUpDown priceNum;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label textLabel;
        public System.Windows.Forms.Label addProcessorLabel;
        private System.Windows.Forms.Button closeButton;
    }
}