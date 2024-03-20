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
    public partial class AddProcessorForm : Form
    {
        private MainForm mainForm;
        public AddProcessorForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        public AddProcessorForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddProduct addProcessor = new AddProcessor(this);
            Product processor = addProcessor.Add();

            mainForm.products.Add(processor);

            mainForm.productDataGridView.Rows.Add(processor.number, processor.name, processor.price);

            this.Close();
        }
    }
}
