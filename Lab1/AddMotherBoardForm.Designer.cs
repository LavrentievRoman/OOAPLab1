namespace Lab1
{
    partial class AddMotherBoardForm
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
            this.addMotherBoardLabel = new System.Windows.Forms.Label();
            this.textLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceNum = new System.Windows.Forms.NumericUpDown();
            this.numberLabel = new System.Windows.Forms.Label();
            this.socketTypeLabel1 = new System.Windows.Forms.Label();
            this.socketTypeComboBox = new System.Windows.Forms.ComboBox();
            this.processNumberLabel = new System.Windows.Forms.Label();
            this.processorNumberNum = new System.Windows.Forms.NumericUpDown();
            this.ramTypeLabel = new System.Windows.Forms.Label();
            this.ramTypeComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.numberNum = new System.Windows.Forms.NumericUpDown();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorNumberNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).BeginInit();
            this.SuspendLayout();
            // 
            // addMotherBoardLabel
            // 
            this.addMotherBoardLabel.AutoSize = true;
            this.addMotherBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMotherBoardLabel.Location = new System.Drawing.Point(65, 9);
            this.addMotherBoardLabel.Name = "addMotherBoardLabel";
            this.addMotherBoardLabel.Size = new System.Drawing.Size(331, 24);
            this.addMotherBoardLabel.TabIndex = 0;
            this.addMotherBoardLabel.Text = "Добавление материнской платы";
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(21, 85);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(76, 16);
            this.textLabel.TabIndex = 2;
            this.textLabel.Text = "Название:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(21, 120);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(43, 16);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Цена:";
            // 
            // priceNum
            // 
            this.priceNum.DecimalPlaces = 2;
            this.priceNum.Location = new System.Drawing.Point(201, 120);
            this.priceNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.priceNum.Name = "priceNum";
            this.priceNum.Size = new System.Drawing.Size(144, 20);
            this.priceNum.TabIndex = 4;
            this.priceNum.Value = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numberLabel.Location = new System.Drawing.Point(21, 55);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(53, 16);
            this.numberLabel.TabIndex = 5;
            this.numberLabel.Text = "Номер:";
            // 
            // socketTypeLabel1
            // 
            this.socketTypeLabel1.AutoSize = true;
            this.socketTypeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.socketTypeLabel1.Location = new System.Drawing.Point(21, 155);
            this.socketTypeLabel1.Name = "socketTypeLabel1";
            this.socketTypeLabel1.Size = new System.Drawing.Size(83, 16);
            this.socketTypeLabel1.TabIndex = 7;
            this.socketTypeLabel1.Text = "Тип сокета:";
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
            this.socketTypeComboBox.Location = new System.Drawing.Point(201, 154);
            this.socketTypeComboBox.Name = "socketTypeComboBox";
            this.socketTypeComboBox.Size = new System.Drawing.Size(93, 21);
            this.socketTypeComboBox.TabIndex = 8;
            // 
            // processNumberLabel
            // 
            this.processNumberLabel.AutoSize = true;
            this.processNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processNumberLabel.Location = new System.Drawing.Point(21, 189);
            this.processNumberLabel.Name = "processNumberLabel";
            this.processNumberLabel.Size = new System.Drawing.Size(174, 16);
            this.processNumberLabel.TabIndex = 9;
            this.processNumberLabel.Text = "Количество процессоров";
            // 
            // processorNumberNum
            // 
            this.processorNumberNum.Location = new System.Drawing.Point(201, 189);
            this.processorNumberNum.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.processorNumberNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.processorNumberNum.Name = "processorNumberNum";
            this.processorNumberNum.Size = new System.Drawing.Size(53, 20);
            this.processorNumberNum.TabIndex = 10;
            this.processorNumberNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ramTypeLabel
            // 
            this.ramTypeLabel.AutoSize = true;
            this.ramTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ramTypeLabel.Location = new System.Drawing.Point(21, 223);
            this.ramTypeLabel.Name = "ramTypeLabel";
            this.ramTypeLabel.Size = new System.Drawing.Size(66, 16);
            this.ramTypeLabel.TabIndex = 11;
            this.ramTypeLabel.Text = "Тип ОЗУ:";
            // 
            // ramTypeComboBox
            // 
            this.ramTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "DDR",
            "DDR2",
            "DDR3",
            "DDR4"});
            this.ramTypeComboBox.FormattingEnabled = true;
            this.ramTypeComboBox.Items.AddRange(new object[] {
            "DDR",
            "DDR2",
            "DDR3",
            "DDR4"});
            this.ramTypeComboBox.Location = new System.Drawing.Point(201, 223);
            this.ramTypeComboBox.Name = "ramTypeComboBox";
            this.ramTypeComboBox.Size = new System.Drawing.Size(83, 21);
            this.ramTypeComboBox.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(165, 288);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(152, 49);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // numberNum
            // 
            this.numberNum.Location = new System.Drawing.Point(201, 51);
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
            this.numberNum.TabIndex = 14;
            this.numberNum.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(201, 84);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(268, 20);
            this.nameTextBox.TabIndex = 15;
            this.nameTextBox.Text = "Материнская плата";
            // 
            // AddMotherBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 349);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberNum);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ramTypeComboBox);
            this.Controls.Add(this.ramTypeLabel);
            this.Controls.Add(this.processorNumberNum);
            this.Controls.Add(this.processNumberLabel);
            this.Controls.Add(this.socketTypeComboBox);
            this.Controls.Add(this.socketTypeLabel1);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.priceNum);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.addMotherBoardLabel);
            this.Name = "AddMotherBoardForm";
            this.Text = "AddMotherBoardForm";
            ((System.ComponentModel.ISupportInitialize)(this.priceNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorNumberNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label addMotherBoardLabel;
        public System.Windows.Forms.Label textLabel;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.NumericUpDown priceNum;
        public System.Windows.Forms.Label numberLabel;
        public System.Windows.Forms.Label socketTypeLabel1;
        public System.Windows.Forms.ComboBox socketTypeComboBox;
        public System.Windows.Forms.Label processNumberLabel;
        public System.Windows.Forms.NumericUpDown processorNumberNum;
        public System.Windows.Forms.Label ramTypeLabel;
        public System.Windows.Forms.ComboBox ramTypeComboBox;
        public System.Windows.Forms.Button AddButton;
        public System.Windows.Forms.NumericUpDown numberNum;
        public System.Windows.Forms.TextBox nameTextBox;
    }
}