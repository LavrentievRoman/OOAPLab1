using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class AddProduct
    {
        public abstract Product Add();

    }

    public class AddMatherBoard : AddProduct
    {
        private AddMotherBoardForm form;
        public AddMatherBoard(AddMotherBoardForm form)
        {
            this.form = form;
        }
        public override Product Add()
        {
            string name, socketType, ramType;
            int number, processorsNumber;
            double price;

            name = form.nameTextBox.Text;
            socketType = form.socketTypeComboBox.Text;
            ramType = form.ramTypeComboBox.Text;
            number = (int)form.numberNum.Value;
            processorsNumber = (int)form.processorNumberNum.Value;
            price = (int)form.priceNum.Value;

            return new Matherboard(name, price, number, socketType, processorsNumber, ramType);
        }

    }

    public class AddHardDisk : AddProduct
    {
        private AddHardDiskForm form;
        public AddHardDisk(AddHardDiskForm form)
        {
            this.form = form;
        }
        public override Product Add()
        {
            string name, interfaceType;
            int number;
            double price, volume, rotationSpeed;

            name = form.nameTextBox.Text;
            number = (int)form.numberNum.Value;
            price = (int)form.priceNum.Value;
            interfaceType = form.inerfaceTypeComboBox.Text;
            volume = (double)form.volumeNum.Value;
            rotationSpeed = (double)form.rotationSpeedNum.Value;


            return new HardDisk(name, price, number, interfaceType, volume, rotationSpeed);
        }

    }

    public class AddProcessor : AddProduct
    {
        private AddProcessorForm form;
        public AddProcessor(AddProcessorForm form)
        {
            this.form = form;
        }
        public override Product Add()
        {
            string name, socketType;
            int number, processorsNumber;
            double price, clockFrequence;

            name = form.nameTextBox.Text;
            number = (int)form.numberNum.Value;
            price = (int)form.priceNum.Value;
            socketType = form.socketTypeComboBox.Text;
            processorsNumber = (int)form.coresNumberNum.Value;
            clockFrequence = (double)form.clockFrequenceNum.Value;


            return new Processor(name, price, number, socketType, processorsNumber, clockFrequence);
        }

    }
}
