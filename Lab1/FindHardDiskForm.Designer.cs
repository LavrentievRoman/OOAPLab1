namespace Lab1
{
    partial class FindHardDiskForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.rotationSpeedNum = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberNum = new System.Windows.Forms.NumericUpDown();
            this.ramTypeLabel = new System.Windows.Forms.Label();
            this.volumeNum = new System.Windows.Forms.NumericUpDown();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.inerfaceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.interfaceTypeLabel1 = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.priceLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.addHardDiskLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSpeedNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(315, 288);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(152, 46);
            this.closeButton.TabIndex = 62;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // rotationSpeedNum
            // 
            this.rotationSpeedNum.DecimalPlaces = 2;
            this.rotationSpeedNum.Enabled = false;
            this.rotationSpeedNum.Location = new System.Drawing.Point(199, 223);
            this.rotationSpeedNum.Name = "rotationSpeedNum";
            this.rotationSpeedNum.Size = new System.Drawing.Size(120, 20);
            this.rotationSpeedNum.TabIndex = 75;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(199, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 20);
            this.nameTextBox.TabIndex = 74;
            this.nameTextBox.Text = "ывыв";
            // 
            // numberNum
            // 
            this.numberNum.Enabled = false;
            this.numberNum.Location = new System.Drawing.Point(199, 51);
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
            this.numberNum.TabIndex = 73;
            this.numberNum.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // ramTypeLabel
            // 
            this.ramTypeLabel.AutoSize = true;
            this.ramTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ramTypeLabel.Location = new System.Drawing.Point(19, 223);
            this.ramTypeLabel.Name = "ramTypeLabel";
            this.ramTypeLabel.Size = new System.Drawing.Size(138, 16);
            this.ramTypeLabel.TabIndex = 72;
            this.ramTypeLabel.Text = "Скорость вращения:";
            // 
            // volumeNum
            // 
            this.volumeNum.Enabled = false;
            this.volumeNum.Location = new System.Drawing.Point(199, 189);
            this.volumeNum.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.volumeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.volumeNum.Name = "volumeNum";
            this.volumeNum.Size = new System.Drawing.Size(53, 20);
            this.volumeNum.TabIndex = 71;
            this.volumeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeLabel.Location = new System.Drawing.Point(19, 189);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(54, 16);
            this.volumeLabel.TabIndex = 70;
            this.volumeLabel.Text = "Объём:";
            // 
            // inerfaceTypeComboBox
            // 
            this.inerfaceTypeComboBox.Enabled = false;
            this.inerfaceTypeComboBox.FormattingEnabled = true;
            this.inerfaceTypeComboBox.Items.AddRange(new object[] {
            "IDE",
            "ATA",
            "PATA",
            "SAITA",
            "mSATA"});
            this.inerfaceTypeComboBox.Location = new System.Drawing.Point(199, 154);
            this.inerfaceTypeComboBox.Name = "inerfaceTypeComboBox";
            this.inerfaceTypeComboBox.Size = new System.Drawing.Size(93, 21);
            this.inerfaceTypeComboBox.TabIndex = 69;
            // 
            // interfaceTypeLabel1
            // 
            this.interfaceTypeLabel1.AutoSize = true;
            this.interfaceTypeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interfaceTypeLabel1.Location = new System.Drawing.Point(19, 155);
            this.interfaceTypeLabel1.Name = "interfaceTypeLabel1";
            this.interfaceTypeLabel1.Size = new System.Drawing.Size(119, 16);
            this.interfaceTypeLabel1.TabIndex = 68;
            this.interfaceTypeLabel1.Text = "Тип интерфейса:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(19, 55);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(53, 16);
            this.numberLabel.TabIndex = 67;
            this.numberLabel.Text = "Номер:";
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Enabled = false;
            this.priceNum.Location = new System.Drawing.Point(199, 120);
            this.priceNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(144, 20);
            this.priceNum.TabIndex = 66;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(19, 120);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 16);
            this.priceLabel.TabIndex = 65;
            this.priceLabel.Text = "Цена:";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(19, 85);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(76, 16);
            this.textLabel.TabIndex = 64;
            this.textLabel.Text = "Название:";
            // 
            // addHardDiskLabel
            // 
            this.addHardDiskLabel.AutoSize = true;
            this.addHardDiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addHardDiskLabel.Location = new System.Drawing.Point(163, 9);
            this.addHardDiskLabel.Name = "addHardDiskLabel";
            this.addHardDiskLabel.Size = new System.Drawing.Size(147, 24);
            this.addHardDiskLabel.TabIndex = 63;
            this.addHardDiskLabel.Text = "Жёсткий диск";
            // 
            // FindHardDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 347);
            this.Controls.Add(this.rotationSpeedNum);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberNum);
            this.Controls.Add(this.ramTypeLabel);
            this.Controls.Add(this.volumeNum);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.inerfaceTypeComboBox);
            this.Controls.Add(this.interfaceTypeLabel1);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.addHardDiskLabel);
            this.Controls.Add(this.closeButton);
            this.Name = "FindHardDiskForm";
            this.Text = "FindHardDiskForm";
            ((System.ComponentModel.ISupportInitialize)(this.rotationSpeedNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        public System.Windows.Forms.NumericUpDown rotationSpeedNum;
        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.NumericUpDown numberNum;
        public System.Windows.Forms.Label ramTypeLabel;
        public System.Windows.Forms.NumericUpDown volumeNum;
        public System.Windows.Forms.Label volumeLabel;
        public System.Windows.Forms.ComboBox inerfaceTypeComboBox;
        public System.Windows.Forms.Label interfaceTypeLabel1;
        public System.Windows.Forms.Label numberLabel;
        public System.Windows.Forms.NumericUpDown priceNum;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label textLabel;
        public System.Windows.Forms.Label addHardDiskLabel;
    }
}