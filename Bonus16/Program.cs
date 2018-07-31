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
                temp.Make = Validator.MakeValidator("Please enter the make of the car (eg. Ford):", "Sorry, that was an invalid input. Please enter the make of the car (eg. Ford):");

                temp.Model = Validator.ModelValidator("Please enter the model of the car (eg. F150):", "Sorry, that was an invalid input. Please enter the model of the car (eg. F150):");

                temp.Year = Validator.YearValidator("Please enter the year of the car (eg. 2005):", "Sorry, that is not a valid year. Please enter the year of the car (1900 to 2019):");

                temp.Price = Validator.PriceValidator("Please enter the price of the car:", "Not a valid price. Please enter the price of the car.");
                cars.Add(temp);

                Console.WriteLine("Would you like to add another car?");
                string choice = Validator.AddChoiceValidator("Would you like to add another car? (Y/N): ", "That wasnt a yes or no, so please be clear! Enter (Y/N or yes/no): ");

                if (choice.ToLower() == "n")
                    break;
            }


            Console.WriteLine($"{"Year",-15}{"Model",-15}{"Make",-15}{"Price in dollars",-20}");
            Console.WriteLine("====================================================");
            foreach (Car c in cars)
            {
                Console.WriteLine(c.ToString());
            }


        }
    }
}
