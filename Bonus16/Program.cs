using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Car> cars = new List<Car>();

            while (true)
            {
                Car temp = new Car();

                Console.WriteLine("Please enter the make of the car:");
                temp.Make = Console.ReadLine();
                Console.WriteLine("Please enter the model of the car:");
                temp.Model = Console.ReadLine();
                Console.WriteLine("Please enter the year of the car:");
                temp.Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the price of the car:");
                temp.Price = double.Parse(Console.ReadLine());
                cars.Add(temp);

                Console.WriteLine("Would you like to add another car?");
                string choice = Console.ReadLine();

                if (choice.ToLower() == "n")
                    break;
            }


            Console.WriteLine($"{"Year",-12}{"Model",-12}{"Make",-12}{"Price in dollars",-20}");
            Console.WriteLine("====================================================");
            foreach (Car c in cars)
            {
                Console.WriteLine($"{c.Year,-12}{c.Model,-12}{c.Make,-12}{c.Price,-20}");
            }


        }
    }
}
