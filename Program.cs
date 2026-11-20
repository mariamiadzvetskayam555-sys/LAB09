using LAB09;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.AccessControl;


// Блюдо 1

Dish beefBuckwheat = new Dish("Говядина с гречкой");

beefBuckwheat.AddToDish(new Meat(
    "Говядина", 250, 187, 45, "Говядина", 10));

beefBuckwheat.AddToDish(new Vegetable(
    "Гречка", 150, 110, 8, true, "Осень"));

beefBuckwheat.AddToDish(new Vegetable(
    "Морковь", 80, 35, 3, true, "Осень"));



// добавить рыбу в блюдо с мясом
beefBuckwheat.AddToDish(new Fish(
    "Треска", 200, 80, 30, "Треска", true));


// Блюдо 2

Dish tunaBroccoli = new Dish("Тунец с брокколи");

tunaBroccoli.AddToDish(new Fish(
    "Тунец", 200, 130, 60, "Тунец", true));

tunaBroccoli.AddToDish(new Vegetable(
    "Брокколи", 150, 34, 12, true, "Лето"));

tunaBroccoli.AddToDish(new Sauce(
    "Сливочный соус", 40, 120, 15, "Сливочный", 1));

// добавить мясо в рыбное блюдо 
tunaBroccoli.AddToDish(new Meat(
    "Курица", 200, 165, 25, "Курица", 5));

// добавить другой соус 
tunaBroccoli.AddToDish(new Sauce(
    "Соевый соус", 30, 53, 8, "Соевый", 2));



// Блюдо 3

Dish turkeyRice = new Dish("Индейка с рисом");

turkeyRice.AddToDish(new Meat(
    "Индейка", 220, 104, 35, "Индейка", 4));

turkeyRice.AddToDish(new Vegetable(
    "Рис", 180, 130, 5, true, "Лето"));

turkeyRice.AddToDish(new Spice(
    "Куркума", 3, 312, 20, "Пряный", 2));


Console.WriteLine();
Console.WriteLine("Блюда и характеристики: ");
Console.WriteLine();

Console.WriteLine(beefBuckwheat);
Console.WriteLine($"Калорийность: {beefBuckwheat.TotalCalories():F2} ккал");
Console.WriteLine($"Стоимость: {beefBuckwheat.TotalCost():F2} руб.");
Console.WriteLine();

Console.WriteLine(tunaBroccoli);
Console.WriteLine($"Калорийность: {tunaBroccoli.TotalCalories():F2} ккал");
Console.WriteLine($"Стоимость: {tunaBroccoli.TotalCost():F2} руб.");
Console.WriteLine();

Console.WriteLine(turkeyRice);
Console.WriteLine($"Калорийность: {turkeyRice.TotalCalories():F2} ккал");
Console.WriteLine($"Стоимость: {turkeyRice.TotalCost():F2} руб.");
Console.WriteLine();


Console.WriteLine();
Console.WriteLine("Сравнение:");
Console.WriteLine();

Console.WriteLine($"Говядина с гречкой == Тунец с брокколи: {beefBuckwheat == tunaBroccoli}");
Console.WriteLine($"Говядина с гречкой != Тунец с брокколи: {beefBuckwheat != tunaBroccoli}");
Console.WriteLine($"Индейка с рисом == Тунец с брокколи: {turkeyRice == tunaBroccoli}");

