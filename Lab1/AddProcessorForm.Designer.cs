namespace Lab1
{
    partial class AddProcessorForm
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
            this.clockFrequenceNum = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberNum = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
            this.clockFrequenceLabel = new System.Windows.Forms.Label();
            this.socketTypeLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.addProcessorLabel = new System.Windows.Forms.Label();
            this.socketTypeComboBox = new System.Windows.Forms.ComboBox();
            this.coresNumberNum = new System.Windows.Forms.NumericUpDown();
            this.coresNumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clockFrequenceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coresNumberNum)).BeginInit();
            this.SuspendLayout();
            // 
            // clockFrequenceNum
            // 
            this.clockFrequenceNum.DecimalPlaces = 2;
            this.clockFrequenceNum.Location = new System.Drawing.Point(201, 237);
            this.clockFrequenceNum.Name = "clockFrequenceNum";
            this.clockFrequenceNum.Size = new System.Drawing.Size(120, 20);
            this.clockFrequenceNum.TabIndex = 44;
            this.clockFrequenceNum.Value = new decimal(new int[] {
            376,
            0,
            0,
            131072});
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(201, 98);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 20);
            this.nameTextBox.TabIndex = 43;
            this.nameTextBox.Text = "Процессор";
            // 
            // numberNum
            // 
            this.numberNum.Location = new System.Drawing.Point(201, 65);
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
            this.numberNum.TabIndex = 42;
            this.numberNum.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(165, 302);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(152, 49);
            this.AddButton.TabIndex = 41;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // clockFrequenceLabel
            // 
            this.clockFrequenceLabel.AutoSize = true;
            this.clockFrequenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clockFrequenceLabel.Location = new System.Drawing.Point(21, 237);
            this.clockFrequenceLabel.Name = "clockFrequenceLabel";
            this.clockFrequenceLabel.Size = new System.Drawing.Size(128, 16);
            this.clockFrequenceLabel.TabIndex = 40;
            this.clockFrequenceLabel.Text = "Тактовая чатсота:";
            // 
            // socketTypeLabel
            // 
            this.socketTypeLabel.AutoSize = true;
            this.socketTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.socketTypeLabel.Location = new System.Drawing.Point(21, 169);
            this.socketTypeLabel.Name = "socketTypeLabel";
            this.socketTypeLabel.Size = new System.Drawing.Size(83, 16);
            this.socketTypeLabel.TabIndex = 36;
            this.socketTypeLabel.Text = "Тип сокета:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(21, 69);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(53, 16);
            this.numberLabel.TabIndex = 35;
            this.numberLabel.Text = "Номер:";
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Location = new System.Drawing.Point(201, 134);
            this.priceNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(144, 20);
            this.priceNum.TabIndex = 34;
            this.priceNum.Value = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(21, 134);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 16);
            this.priceLabel.TabIndex = 33;
            this.priceLabel.Text = "Цена:";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(21, 99);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(76, 16);
            this.textLabel.TabIndex = 32;
            this.textLabel.Text = "Название:";
            // 
            // addProcessorLabel
            // 
            this.addProcessorLabel.AutoSize = true;
            this.addProcessorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProcessorLabel.Location = new System.Drawing.Point(108, 18);
            this.addProcessorLabel.Name = "addProcessorLabel";
            this.addProcessorLabel.Size = new System.Drawing.Size(254, 24);
            this.addProcessorLabel.TabIndex = 31;
            this.addProcessorLabel.Text = "Добавление процессора";
            // 
            // socketTypeComboBox
            // 
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
            this.socketTypeComboBox.Location = new System.Drawing.Point(201, 169);
            this.socketTypeComboBox.Name = "socketTypeComboBox";
            this.socketTypeComboBox.Size = new System.Drawing.Size(93, 21);
            this.socketTypeComboBox.TabIndex = 45;
            // 
            // coresNumberNum
            // 
            this.coresNumberNum.Location = new System.Drawing.Point(201, 203);
            this.coresNumberNum.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.coresNumberNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.coresNumberNum.Name = "coresNumberNum";
            this.coresNumberNum.Size = new System.Drawing.Size(53, 20);
            this.coresNumberNum.TabIndex = 47;
            this.coresNumberNum.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // coresNumberLabel
            // 
            this.coresNumberLabel.AutoSize = true;
            this.coresNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coresNumberLabel.Location = new System.Drawing.Point(21, 203);
            this.coresNumberLabel.Name = "coresNumberLabel";
            this.coresNumberLabel.Size = new System.Drawing.Size(122, 16);
            this.coresNumberLabel.TabIndex = 46;
            this.coresNumberLabel.Text = "Количество ядер:";
            // 
            // AddProcessorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 450);
            this.Controls.Add(this.coresNumberNum);
            this.Controls.Add(this.coresNumberLabel);
            this.Controls.Add(this.socketTypeComboBox);
            this.Controls.Add(this.clockFrequenceNum);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberNum);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.clockFrequenceLabel);
            this.Controls.Add(this.socketTypeLabel);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.addProcessorLabel);
            this.Name = "AddProcessorForm";
            this.Text = "AddProcessorForm";
            ((System.ComponentModel.ISupportInitialize)(this.clockFrequenceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coresNumberNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.NumericUpDown clockFrequenceNum;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.NumericUpDown numberNum;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.Label clockFrequenceLabel;
        public System.Windows.Forms.Label socketTypeLabel;
        public System.Windows.Forms.Label numberLabel;
        public System.Windows.Forms.NumericUpDown priceNum;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label textLabel;
        public System.Windows.Forms.Label addProcessorLabel;
        public System.Windows.Forms.ComboBox socketTypeComboBox;
        public System.Windows.Forms.NumericUpDown coresNumberNum;
        public System.Windows.Forms.Label coresNumberLabel;
    }
}