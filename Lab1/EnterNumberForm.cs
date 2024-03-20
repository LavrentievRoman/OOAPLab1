using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class EnterNumberForm : Form
    {
        private MainForm mainForm;
        public EnterNumberForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            Product product = mainForm.products.Find(i => i.number == int.Parse(enterNumberTextBox.Text));

            if (product != null) 
            {
                if (product.productType == "matherboard")
                {
                    FindMatherBoardForm form = new FindMatherBoardForm();
                    Matherboard matherboard = (Matherboard)product;

                    form.nameTextBox.Text = matherboard.name;
                    form.numberNum.Value = matherboard.number;
                    form.priceNum.Value = (decimal)matherboard.price;
                    form.socketTypeComboBox.Text = matherboard.socketType;
                    form.processorNumberNum.Value = matherboard.processorsNumber;
                    form.ramTypeComboBox.Text = matherboard.ramType;

                    form.Show();
                    this.Close();

                }

                if (product.productType == "processor")
                {
                    FindProcessorForm form = new FindProcessorForm();
                    Processor processor = (Processor)product;

                    form.nameTextBox.Text = processor.name;
                    form.numberNum.Value = processor.number;
                    form.priceNum.Value = (decimal)processor.price;
                    form.socketTypeComboBox.Text = processor.socketType;
                    form.coreNumberNum.Value = processor.coresNumber;
                    form.clockFrequenceNum.Value = (decimal)processor.clockFrequence;

                    form.Show();
                    this.Close();
                }

                if (product.productType == "hardDisk")
                {
                    FindHardDiskForm form = new FindHardDiskForm();
                    HardDisk hardDisk = (HardDisk)product;

                    form.nameTextBox.Text = hardDisk.name;
                    form.numberNum.Value = hardDisk.number;
                    form.priceNum.Value = (decimal)hardDisk.price;
                    form.inerfaceTypeComboBox.Text = hardDisk.interfaceType;
                    form.volumeNum.Value = (decimal)hardDisk.volume;
                    form.rotationSpeedNum.Value = (decimal)hardDisk.rotationSpeed;

                    form.Show();
                    this.Close();
                }
            }

            else
            {
                FindNothingForm form = new FindNothingForm();

                form.Show();
                this.Close();
            }
        }
    }
}
