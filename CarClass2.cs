using System;

//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace EnriquezObjectOrientedProgramming
{
    //Gets the information for a car
    public class Car
    {
        //These are the properties of a car
        public string Model { get; set; }
        public int Year { get; set; }
        private double _price;
        public double Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                    _price = value;
                else
                    throw new ArgumentException("The price can't be negative");
            }
        }

        //The following are the constructors
        public Car()
        {
            //Default constructor
        }

        public Car(string model, int year, double price)
        {
            //These are the non default 
            Model = model;
            Year = year;
            Price = price;
        }

        //These are the methods
        public double CalculateDepreciation()
        {
            //This is with the assumption that the depreciation rate is 10% per year
            int currentYear = DateTime.Now.Year;
            int yearsOld = currentYear - Year;
            double depreciation = Price * 0.1 * yearsOld;
            return Price - depreciation;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Year: {Year}, Price: ${Price:N2}";
        }
    }
}

