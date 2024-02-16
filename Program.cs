// See https://aka.ms/new-console-template for more information

using CalcExample;

Calc calc = new Calc();
Console.WriteLine("Add call");
calc.Add(30, 50);

Console.WriteLine("Sub call");
calc.Sub(30, 50);

Console.WriteLine("Div call");
calc.Div(40, 5);

Console.WriteLine("Multi call");
calc.Multi(3, 9);