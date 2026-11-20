using LAB09;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LAB09
{
    public class Dish
    {
        public string Name { get; set; }

        private List<Ingridient> ingredients;

        public Dish(string name)
        {
            Name = name;
            ingredients = new List<Ingridient>();
        }

        public void AddToDish(Ingridient ingredient)
        {
            if (ingredient == null) return;

            bool hasMeat = false;
            bool hasFish = false;
            int sauceCount = 0;
            string existingSauceType = "";

            foreach (Ingridient ing in ingredients)
            {
                if (ing is Meat) hasMeat = true;
                if (ing is Fish) hasFish = true;
                if (ing is Sauce s)
                {
                    sauceCount++;
                    existingSauceType = s.SauceType;
                }
            }

            if (ingredient is Meat && hasFish)
            {
                Console.WriteLine($"Нельзя добавить мясо ({ingredient.Name}), в блюде уже есть рыба!");
                return;
            }

            if (ingredient is Fish && hasMeat)
            {
                Console.WriteLine($"Нельзя добавить рыбу ({ingredient.Name}), в блюде уже есть мясо!");
                return;
            }

            if (ingredient is Sauce newSauce)
            {
                if (sauceCount > 0 && existingSauceType != newSauce.SauceType)
                {
                    Console.WriteLine($"Нельзя добавить соус '{newSauce.SauceType}', в блюде уже есть соус '{existingSauceType}'!");
                    return;
                }
            }

            ingredients.Add(ingredient);
            Console.WriteLine($"{ingredient.GetType().Name} '{ingredient.Name}' добавлен в блюдо.");
        }

        public double TotalCalories()
        {
            double total = 0;

            foreach (Ingridient ing in ingredients)
            {
                if (ing is IDiet dietItem)
                {
                    total += dietItem.RecalculateCalories();
                }
                else
                {
                    total += (ing.Calories * ing.Mass) / 100.0;
                }
            }
            return total;
        }

        public double TotalCost()
        {
            double total = 0;
            foreach (Ingridient ing in ingredients)
            {
                if (ing is IDiet dietItem)
                {
                    total += dietItem.RecalculatePrice();
                }
                else
                {
                    total += (ing.Price * ing.Mass) / 100.0;
                }
            }
            return total;
        }

        public override string ToString()
        {
            string result = $"Блюдо: {Name}\n";

            foreach (Ingridient ing in ingredients)
            {
                result += ing.ToString() + "\n";
            }

            result += $"Итого калорий: {TotalCalories():F2}, Итого стоимость: {TotalCost():F2}";
            return result;
        }

        public static bool operator ==(Dish d1, Dish d2)
        {
            if (ReferenceEquals(d1, d2)) return true;
            if (d1 is null || d2 is null) return false;

            if (d1.TotalCost() == d2.TotalCost() && d1.TotalCalories() == d2.TotalCalories())
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Dish d1, Dish d2)
        {
            return !(d1 == d2);
        }

        public override bool Equals(object obj)
        {
            return obj is Dish dish && this == dish;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(TotalCost(), TotalCalories());
        }
    }
}
