using LAB09;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    public class Fish : Ingridient, IDiet
    {
        public string FishType { get; set; } 
        public bool IsSea { get; set; }

        public Fish(string name, double mass, double calories, double price, string fishType, bool isSea)
            : base(name, mass, calories, price)
        {
            FishType = fishType;
            IsSea = isSea;
        }

        public double RecalculateCalories()
        {
            return (Calories * Mass / 100) * 0.9;
        }

        public double RecalculatePrice()
        {
            return (Price * Mass / 100) * 0.95;
        }

        public override string ToString()
        {
            return base.ToString() + $", Вид: {FishType}, Морская: {IsSea}";
        }
    }
}