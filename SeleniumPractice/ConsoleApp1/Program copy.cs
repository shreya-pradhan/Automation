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
            console.WriteLine("car has started")
        }

            
    }

    public ElectricCar : Car
    {
        public string engineType;

        public void getEngineType()
        {
            console.WriteLine(engineType)
        }

        public static void main (string []args)
        {
            ElectricCar tesla= new ElectricCar();
            tesla.startCar();
            tesla.getEngineType()
        }
    }


     
}
