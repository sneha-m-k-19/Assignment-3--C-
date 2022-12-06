using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Consumer
    {
        private int _consumerId;
        private string _consumerName;

        public int ConsumerId
        { get => _consumerId; set => _consumerId = value; }
        public string ConsumerName { get => _consumerName; set => _consumerName = value; }

        public void Consumer_Read()
        {
            Console.WriteLine("Enter the Consumer ID: ");
            ConsumerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Consumer Name: ");
            ConsumerName = Console.ReadLine();
        }

        public void Consumer_Display()
        {
            Console.WriteLine("Consumer ID: " + ConsumerId);
            Console.WriteLine("Consumer Name: " + ConsumerName);
        }
    }

    class Consumption : Consumer
    {
        private double _unitPrevious;
        private double _unitCurrent;
        private double _unitConsumed;

        protected double UnitConsumed { get => _unitConsumed; set => _unitConsumed = value; }

        public double UnitPrevious { get => _unitPrevious; set => _unitPrevious = value; }
        public double UnitCurrent { get => _unitCurrent; set => _unitCurrent = value; }

        public void Consumption_Read()
        {
            base.Consumer_Read();
            Console.WriteLine("Enter the Previous unit ");
            UnitPrevious = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the current unit");
            UnitCurrent = Convert.ToDouble(Console.ReadLine());
        }

        public void Consumption_Calculate()
        {
            UnitConsumed = UnitCurrent - UnitPrevious;
        }

        public void Consumption_Display()
        {
            base.Consumer_Display();
            Console.WriteLine("Unit Consumed: " + UnitConsumed);
        }
    }

    class Bill : Consumption
    {
        private double _amount;

        public double Amount { get => _amount; set => _amount = value; }

        public void Bill_Calculate()
        {

            Consumption_Calculate();
            Amount = UnitConsumed * 0.5;
        }

        public void Bill_Display()
        {
            Consumption_Display();
            Console.WriteLine("Amount Payable: " + Amount);
        }
    }
    class BillPayment
    {
        static void Main(string[] args)
        {
            Bill bill = new Bill();
            bill.Consumption_Read();
            bill.Bill_Calculate();
            bill.Bill_Display();
            Console.ReadLine();
        }
    }
}
