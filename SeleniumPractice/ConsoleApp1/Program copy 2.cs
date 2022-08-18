using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    { 
        public string color;
        public string weight;

        public void startCar()
        {
            Console.WriteLine("car has started");
            
        }

            
    }

    public  class ElectricCar : Car
    {
        public string engineType;

        public void getEngineType()
        {
            Console.WriteLine(engineType);
        }

        public static void main (string []args)
        {
            ElectricCar tesla= new ElectricCar();
            tesla.startCar();
            tesla.getEngineType()
        }
    }


     
}
