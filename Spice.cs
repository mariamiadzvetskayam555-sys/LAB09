using LAB09;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    public class Spice : Ingridient 
    {
        public string Aroma { get; set; }
        public double Strength { get; set; }

        public Spice(string name, double mass, double calories, double price, string aroma, double strength)
            : base(name, mass, calories, price)
        {
            Aroma = aroma;
            Strength = strength;
        }

        public override string ToString()
        {
            return base.ToString() + $", Аромат: {Aroma}, Сила: {Strength}";
        }
    }
}
