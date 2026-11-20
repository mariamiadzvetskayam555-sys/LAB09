using LAB09;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    public class Vegetable : Ingridient
    {
        public bool IsOrganic { get; set; }
        public string Season { get; set; }

        public Vegetable(string name, double mass, double calories, double price, bool isOrganic, string season)
            : base(name, mass, calories, price)
        {
            IsOrganic = isOrganic;
            Season = season;
        }

        public override string ToString()
        {
            return base.ToString() + $", Органический: {IsOrganic}, Сезон: {Season}";
        }
    }
}