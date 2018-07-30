using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Car
    {

        // Fields
        private string make;
        private string model;
        private int year;
        private double price;


        #region Properties
        // Properties
        public string Make
        {
            set { make = value; }
            get { return make; }
        }
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        public int Year
        {
            set { year = value; }
            get { return year; }
        }
        public double Price
        {
            set { price = value; }
            get { return price; }
        }
        #endregion


    }
}
