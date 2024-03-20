using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class AddHardDiskForm : Form
    {
        private MainForm mainForm;

        public AddHardDiskForm(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;          
        }
        public AddHardDiskForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddProduct addHardDisk = new AddHardDisk(this);
            Product hardDisk = addHardDisk.Add();

            mainForm.products.Add(hardDisk);

            mainForm.productDataGridView.Rows.Add(hardDisk.number, hardDisk.name, hardDisk.price);

            this.Close();
        }
    }
}
