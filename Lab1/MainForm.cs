using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        public List<Product> products = new List<Product>();
        public MainForm()
        {
            InitializeComponent();       
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);

            addForm.Show();           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            EnterNumberForm enterNumberForm = new EnterNumberForm(this);

            enterNumberForm.Show();
        }
    }

}
