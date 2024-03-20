namespace Lab1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productLabel.Location = new System.Drawing.Point(12, 26);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(93, 20);
            this.productLabel.TabIndex = 1;
            this.productLabel.Text = "Продукты";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(468, 396);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 42);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(468, 331);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(110, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Найти";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AllowUserToOrderColumns = true;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.productDataGridView.Location = new System.Drawing.Point(15, 58);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.Size = new System.Drawing.Size(422, 380);
            this.productDataGridView.TabIndex = 4;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.NullValue = null;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Номер";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 450);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.productLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button searchButton;
        public System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}

