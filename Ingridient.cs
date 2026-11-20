using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    public class Ingridient
    {
        public string Name { get; set; }
        public double Mass { get; set; } 
        public double Calories { get; set; } 
        public double Price { get; set; } 

        public Ingridient(string name, double mass, double calories, double price)
        {
            Name = name;
            Mass = mass;
            Calories = calories;
            Price = price;
        }

        public override string ToString()
        {
            return $"{GetType().Name}: {Name}, Масса: {Mass}г, Ккал: {Calories}/100г, Цена: {Price}руб";
        }
    }
}
