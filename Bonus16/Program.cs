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

            Car car1 = new Car("Ford", "Fusion", 2013, 19800);
            Car car2 = new Car("Toyota", "Prius", 2018, 24370);
            Car car3 = new Car("Dodge", "Durango", 2016, 22100);
            UsedCar used1 = new UsedCar("Ford", "F150", 2004, 7300, 76405.2);
            UsedCar used2 = new UsedCar("Hyundai", "Sonata", 2011, 6700, 67130);
            UsedCar used3 = new UsedCar("Ford", "Flex", 2013, 16400, 24607);

            List<Car> cars = new List<Car>() { car1, car2, car3, used1, used2, used3 };
            while (true)
            {

                for (int i = 0; i < cars.Count; i++)
                {
                    Console.WriteLine($"{i + 1}: {cars[i].ToString()}");
                }
                int carSelection = Validator.ListChoiceValidator("Select which car you would like: ", $"Not a valid input! Please input between 1 and {cars.Count}",
                    $"Not within range. Please enter a number between 1 and {cars.Count}", cars.Count);

                Console.WriteLine($"{"Year",-15}{"Model",-15}{"Make",-15}{"Price in dollars",-20}");
                Console.WriteLine("=============================================================");
                Console.WriteLine(cars[carSelection - 1].ToString());

                string choice = Validator.AddChoiceValidator("Would you like to buy this car? (Y/N): ", "That wasnt a yes or no, so please be clear! Enter (Y/N or yes/no): ");
                if (choice.ToLower() == "y" | choice.ToLower() == "yes")
                {
                    cars.RemoveAt(carSelection - 1);
                }

                string continueChoice = Validator.ContinueChoiceValidator("Would you like to buy another car?: ", "That wasn't a yes or no, please be clear! Enter (Y/N or yes/no): ");

                if (continueChoice.ToLower() == "n" | continueChoice.ToLower() == "no")
                {
                    break;
                }
            }  

            #region AddCarLoop
            //while (true)
            //{
            //    Car temp = new Car();
            //    temp.Make = Validator.MakeValidator("Please enter the make of the car (eg. Ford):", "Sorry, that was an invalid input. Please enter the make of the car (eg. Ford):");

            //    temp.Model = Validator.ModelValidator("Please enter the model of the car (eg. F150):", "Sorry, that was an invalid input. Please enter the model of the car (eg. F150):");

            //    temp.Year = Validator.YearValidator("Please enter the year of the car (eg. 2005):", "Sorry, that is not a valid year. Please enter the year of the car (1900 to 2019):");

            //    temp.Price = Validator.PriceValidator("Please enter the price of the car:", "Not a valid price. Please enter the price of the car.");
            //    cars.Add(temp);

            //    string choice = Validator.AddChoiceValidator("Would you like to add another car? (Y/N): ", "That wasnt a yes or no, so please be clear! Enter (Y/N or yes/no): ");

            //    if (choice.ToLower() == "n")
            //        break;
            //}
            #endregion

            //Console.WriteLine($"{"Year",-15}{"Model",-15}{"Make",-15}{"Price in dollars",-20}");
            //Console.WriteLine("=============================================================");
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine(c.ToString());
            //}


        }
    }
}
