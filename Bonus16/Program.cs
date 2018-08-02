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

            CarLot carLot = new CarLot(cars);

            while (true)
            {
                Console.WriteLine($"#: {"Year",-15}{"Model",-15}{"Make",-15}{"Price",-15}{"Mileage (When used)"}");
                Console.WriteLine("=================================================================================");

                carLot.ListCars(cars);

                while (true)
                {
                    string addBuyReplace = Validator.AddBuyReplaceValidator("Would you like to add a car to the list, replace a car, or buy a car? (Please enter 'add', 'replace', or 'buy')", "That was not add, buy, or replace. Please enter one of those three options");

                    if (addBuyReplace.ToLower() == "buy")
                    {
                        int carSelection = Validator.ListChoiceValidator("Select which car you would like: ", $"Not a valid input! Please input between 1 and {carLot.Lot.Count}",
                            $"Not within range. Please enter a number between 1 and {carLot.Lot.Count}", carLot.Lot.Count);

                        Console.WriteLine($"{"Year",-15}{"Model",-15}{"Make",-15}{"Price",-15}{"Mileage (When used)"}");
                        Console.WriteLine("=================================================================================");
                        Console.WriteLine(carLot.Lot[carSelection - 1].ToString());

                        string choice = Validator.AddChoiceValidator("Would you like to buy this car? (Y/N): ", "That wasnt a yes or no, so please be clear! Enter (Y/N or yes/no): ");
                        if (choice.ToLower() == "y" | choice.ToLower() == "yes")
                        {
                            carLot.RemoveCar(carSelection);
                        }

                        break;
                    }
                    else if (addBuyReplace.ToLower() == "replace")
                    {
                        int carSelection = Validator.ListChoiceValidator("Select which car you would like to replace: ", $"Not a valid input! Please input between 1 and {carLot.Lot.Count}",
                             $"Not within range. Please enter a number between 1 and {carLot.Lot.Count}", carLot.Lot.Count);

                        Console.WriteLine($"{"Year",-15}{"Model",-15}{"Make",-15}{"Price",-15}{"Mileage (When used)"}");
                        Console.WriteLine("=================================================================================");
                        Console.WriteLine(carLot.Lot[carSelection - 1].ToString());

                        carLot.ReplaceCar(cars, carSelection);

                        break;

                    }
                    else
                    {
                        carLot.Lot.Add(carLot.AddCar());

                        break;
                    }
                }
                string continueChoice = Validator.ContinueChoiceValidator("Would you like to see the list of cars?: ", "That wasn't a yes or no, please be clear! Enter (Y/N or yes/no): ");

                if (continueChoice.ToLower() == "y" | continueChoice.ToLower() == "yes")
                {
                    Console.Clear();
                }
                else
                {
                    break;
                }
            }

            Console.ReadKey();

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

            //Console.WriteLine($"{"Year",-15}{"Model",-15}{"Make",-15}{"Price in dollars",-20}");
            //Console.WriteLine("=============================================================");
            //foreach (Car c in cars)
            //{
            //    Console.WriteLine(c.ToString());
            //}
            #endregion


        }
    }
}
