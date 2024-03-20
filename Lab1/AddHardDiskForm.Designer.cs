namespace Lab1
{
    partial class AddHardDiskForm
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberNum = new System.Windows.Forms.NumericUpDown();
            this.AddButton = new System.Windows.Forms.Button();
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
            this.rotationSpeedNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSpeedNum)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(221, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 20);
            this.nameTextBox.TabIndex = 29;
            this.nameTextBox.Text = "Жёсткий диск";
            // 
            // numberNum
            // 
            this.numberNum.Location = new System.Drawing.Point(221, 51);
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
            this.numberNum.TabIndex = 28;
            this.numberNum.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(185, 288);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(152, 49);
            this.AddButton.TabIndex = 27;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ramTypeLabel
            // 
            this.ramTypeLabel.AutoSize = true;
            this.ramTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ramTypeLabel.Location = new System.Drawing.Point(41, 223);
            this.ramTypeLabel.Name = "ramTypeLabel";
            this.ramTypeLabel.Size = new System.Drawing.Size(138, 16);
            this.ramTypeLabel.TabIndex = 25;
            this.ramTypeLabel.Text = "Скорость вращения:";
            // 
            // volumeNum
            // 
            this.volumeNum.Location = new System.Drawing.Point(221, 189);
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
            this.volumeNum.TabIndex = 24;
            this.volumeNum.Value = new decimal(new int[] {
            512,
            0,
            0,
            0});
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeLabel.Location = new System.Drawing.Point(41, 189);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(54, 16);
            this.volumeLabel.TabIndex = 23;
            this.volumeLabel.Text = "Объём:";
            // 
            // inerfaceTypeComboBox
            // 
            this.inerfaceTypeComboBox.FormattingEnabled = true;
            this.inerfaceTypeComboBox.Items.AddRange(new object[] {
            "IDE",
            "ATA",
            "PATA",
            "SAITA",
            "mSATA"});
            this.inerfaceTypeComboBox.Location = new System.Drawing.Point(221, 154);
            this.inerfaceTypeComboBox.Name = "inerfaceTypeComboBox";
            this.inerfaceTypeComboBox.Size = new System.Drawing.Size(93, 21);
            this.inerfaceTypeComboBox.TabIndex = 22;
            // 
            // interfaceTypeLabel1
            // 
            this.interfaceTypeLabel1.AutoSize = true;
            this.interfaceTypeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.interfaceTypeLabel1.Location = new System.Drawing.Point(41, 155);
            this.interfaceTypeLabel1.Name = "interfaceTypeLabel1";
            this.interfaceTypeLabel1.Size = new System.Drawing.Size(119, 16);
            this.interfaceTypeLabel1.TabIndex = 21;
            this.interfaceTypeLabel1.Text = "Тип интерфейса:";
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(41, 55);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(53, 16);
            this.numberLabel.TabIndex = 20;
            this.numberLabel.Text = "Номер:";
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Location = new System.Drawing.Point(221, 120);
            this.priceNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(144, 20);
            this.priceNum.TabIndex = 19;
            this.priceNum.Value = new decimal(new int[] {
            8000,
            0,
            0,
            0});
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(41, 120);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 16);
            this.priceLabel.TabIndex = 18;
            this.priceLabel.Text = "Цена:";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(41, 85);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(76, 16);
            this.textLabel.TabIndex = 17;
            this.textLabel.Text = "Название:";
            // 
            // addHardDiskLabel
            // 
            this.addHardDiskLabel.AutoSize = true;
            this.addHardDiskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addHardDiskLabel.Location = new System.Drawing.Point(85, 9);
            this.addHardDiskLabel.Name = "addHardDiskLabel";
            this.addHardDiskLabel.Size = new System.Drawing.Size(293, 24);
            this.addHardDiskLabel.TabIndex = 16;
            this.addHardDiskLabel.Text = "Добавление жёсткого диска";
            // 
            // rotationSpeedNum
            // 
            this.rotationSpeedNum.DecimalPlaces = 2;
            this.rotationSpeedNum.Location = new System.Drawing.Point(221, 223);
            this.rotationSpeedNum.Name = "rotationSpeedNum";
            this.rotationSpeedNum.Size = new System.Drawing.Size(120, 20);
            this.rotationSpeedNum.TabIndex = 30;
            this.rotationSpeedNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // AddHardDiskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 450);
            this.Controls.Add(this.rotationSpeedNum);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberNum);
            this.Controls.Add(this.AddButton);
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
            this.Name = "AddHardDiskForm";
            this.Text = "AddHardDiskForm";
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotationSpeedNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox nameTextBox;
        public System.Windows.Forms.NumericUpDown numberNum;
        public System.Windows.Forms.Button AddButton;
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
        public System.Windows.Forms.NumericUpDown rotationSpeedNum;
    }
}