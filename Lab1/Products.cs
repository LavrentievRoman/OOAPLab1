using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public abstract class Product
    {
        public string name;
        public double price;
        public int number;

        public string productType;
    }

    public class Matherboard : Product
    {
        public string socketType;
        public int processorsNumber;
        public string ramType;

        public Matherboard(string name, double price, int number, string socketType, int processorsNumber, string ramType)
        {
            this.name = name;
            this.price = price;
            this.number = number;
            this.socketType = socketType;
            this.processorsNumber = processorsNumber;
            this.ramType = ramType;

            productType = "matherboard";
        }
    }

    public class Processor : Product
    {
        public string socketType;
        public int coresNumber;
        public double clockFrequence;

        public Processor(string name, double price, int number, string socketType, int coresNumber, double clockFrequence)
        {
            this.name = name;
            this.price = price;
            this.number = number;
            this.socketType = socketType;
            this.coresNumber = coresNumber;
            this.clockFrequence = clockFrequence;

            productType = "processor";
        }
    }

    public class HardDisk : Product
    {
        public string interfaceType;
        public double volume;
        public double rotationSpeed;

        public HardDisk(string name, double price, int number, string interfaceType, double volume, double rotationSpeed)
        {
            this.name = name;
            this.price = price;
            this.number = number;
            this.interfaceType = interfaceType;
            this.volume = volume;
            this.rotationSpeed = rotationSpeed;

            productType = "hardDisk";
        }
    }
}
