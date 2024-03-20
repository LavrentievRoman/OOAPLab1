using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab1
{
    public partial class AddMotherBoardForm : Form
    {
        private MainForm form;
        public AddMotherBoardForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        public AddMotherBoardForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddProduct addMatherBoard = new AddMatherBoard(this);
            Product matherboard = addMatherBoard.Add();

            form.products.Add(matherboard);

            form.productDataGridView.Rows.Add(matherboard.number, matherboard.name, matherboard.price);

            this.Close();
        }
    }

}
