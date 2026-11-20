using LAB09;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    public class Meat : Ingridient, IDiet
    {
        public string MeatType { get; set; } 
        public double FatPercent { get; set; }

        public Meat(string name, double mass, double calories, double price, string meatType, double fatPercent)
            : base(name, mass, calories, price)
        {
            MeatType = meatType;
            FatPercent = fatPercent;
        }

        public double RecalculateCalories()
        {
            return (Calories - FatPercent / 100 * 8) * Mass / 100;
        }

        public double RecalculatePrice()
        {
            return (Price * Mass / 100) * 0.9;
        }

        public override string ToString()
        {
            return base.ToString() + $", Тип: {MeatType}, Жирность: {FatPercent}%";
        }
    }
}
