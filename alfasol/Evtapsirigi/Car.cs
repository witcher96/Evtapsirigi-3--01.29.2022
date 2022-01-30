using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evtapsirigi
{
    class Car
    {
        public string name;
        public string model;
        public string color;
        public string city;
        public string New;
        public string engineType;
        public double cost;

        public string getinfo()
        {
            string output = $"{name}\n " +
                $"{model}\n" +
                $" {city}\n " +
                $"{New}\n" +
                $" {engineType}\n" +
                $" {cost} Azn\n" +
                $" ==============";

            return output;

        }
    }
}
