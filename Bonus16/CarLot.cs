using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class CarLot
    {
        private List<Car> lot;

        public List<Car> Lot
        {
            set { lot = value; }
            get { return lot;  }
        }

        public CarLot(List<Car> carList)
        {
            Lot = carList;
        }

        public void RemoveCar(int selection)
        {
            Lot.RemoveAt(selection - 1);
        }

        public void ListCars(List<Car> currentList)
        {

            for (int i = 0; i < currentList.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {currentList[i].ToString()}");
            }

        }

        public Car AddCar()
        {
            string usedOrNew = Validator.UsedChoiceValidator("Is the car you want to add new, or used? (Please enter \"new\" or \"used\")", "That wasn't \"new\" or \"used\". Please enter one of those choices.");

            if (usedOrNew.ToLower() == "new")
            {
                Car temp = new Car();
                temp.Make = Validator.MakeValidator("Please enter the make of the car (eg. Ford):", "Sorry, that was an invalid input. Please enter the make of the car (eg. Ford):");

                temp.Model = Validator.ModelValidator("Please enter the model of the car (eg. F150):", "Sorry, that was an invalid input. Please enter the model of the car (eg. F150):");

                temp.Year = Validator.YearValidator("Please enter the year of the car (eg. 2005):", "Sorry, that is not a valid year. Please enter the year of the car (1900 to 2019):");

                temp.Price = Validator.PriceValidator("Please enter the price of the car:", "Not a valid price. Please enter the price of the car.");

                return temp;
            }
            else
            {
                UsedCar temp = new UsedCar();
                temp.Make = Validator.MakeValidator("Please enter the make of the car (eg. Ford):", "Sorry, that was an invalid input. Please enter the make of the car (eg. Ford):");

                temp.Model = Validator.ModelValidator("Please enter the model of the car (eg. F150):", "Sorry, that was an invalid input. Please enter the model of the car (eg. F150):");

                temp.Year = Validator.YearValidator("Please enter the year of the car (eg. 2005):", "Sorry, that is not a valid year. Please enter the year of the car (1900 to 2019):");

                temp.Price = Validator.PriceValidator("Please enter the price of the car:", "Not a valid price. Please enter the price of the car.");

                temp.Mileage = Validator.MileageValidator("Please enter the mileage on the used car.", "Not a valid mileage, please enter the mileage of the used car.");
                return temp;

            }

        }



    }
}
