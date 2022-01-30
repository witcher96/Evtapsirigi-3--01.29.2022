using System;
using System.Text;

namespace Evtapsirigi
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Car car1 = new Car();
            car1.name = "BMW";
            car1.model = "X5";
            car1.city = "Baki";
            car1.engineType = "Diesel";
            car1.color = "Black";
            car1.New = "Beli";
            car1.cost = 15.500;

            Car car2 = new Car();
            car2.name = "Mercedes";
            car2.model = "SClass";
            car2.city = "Lenkeran";
            car2.engineType = "Gasoline";
            car2.color = "Red";
            car2.New = "Xeyr";
            car2.cost = 25.500;

            Car car3 = new Car();
            car3.name = "Lamborghini";
            car3.model = "Sisto elemento";
            car3.city = "Milan";
            car3.engineType = "Gasoline";
            car3.color = "Purple";
            car3.New = "Beli";
            car3.cost = 850.500;



            Car[] cars = new Car[3];
            cars[0] = car1;
            cars[1] = car2;
            cars[2] = car3;

            foreach (Car item in cars)
            {
                item.getinfo();
                Console.WriteLine(item.getinfo());
            }
        }
    }
}
