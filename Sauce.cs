using LAB09;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    public class Sauce : Ingridient, IDiet
    {
        public string SauceType { get; set; }
        public double Spiciness { get; set; } 

        public Sauce(string name, double mass, double calories, double price, string sauceType, double spiciness)
            : base(name, mass, calories, price)
        {
            SauceType = sauceType;
            Spiciness = spiciness;
        }

        public double RecalculateCalories()
        {
            return (Calories * Mass / 100) * 0.8;
        }

        public double RecalculatePrice()
        {
            return (Price * Mass / 100) * 0.9;
        }

        public override string ToString()
        {
            return base.ToString() + $", Тип: {SauceType}, Острота: {Spiciness}";
        }
    }
}
