using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class UsedCar : Car
    {
        private double mileage;

        public double Mileage
        {
            set { mileage = value; }
            get { return mileage; }
        }

        public UsedCar()
        {
            Make = "";
            Model = "";
            Year = 1900;
            Price = 0;
            Mileage = 0;
        }

        public UsedCar(string m, string mod, int y, double p, double mile) : base(m, mod, y, p)
        {
            Mileage = mile;
        }

    }
}
