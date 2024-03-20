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
    public partial class AddForm : Form
    {
        private MainForm form;
        public AddForm(MainForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void addMotherBoardButton_Click(object sender, EventArgs e)
        {
            AddMotherBoardForm addMotherBoardForm = new AddMotherBoardForm(form);

            addMotherBoardForm.Show();
            this.Close();
        }

        private void addProcessorButton_Click(object sender, EventArgs e)
        {
            AddProcessorForm addProcessorForm = new AddProcessorForm(form);

            addProcessorForm.Show();
            this.Close();
        }

        private void AddHardDiskButton_Click(object sender, EventArgs e)
        {
            AddHardDiskForm addHardDiskForm = new AddHardDiskForm(form);

            addHardDiskForm.Show();
            this.Close();
        }
    }
}
