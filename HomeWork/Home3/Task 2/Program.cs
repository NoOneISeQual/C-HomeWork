﻿// Принимает координаты двух точек инаходит расстояние между точками в 2D простран стве
Console.Clear();
Console.Write("Введите координату X(1): ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y(1): ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату X(2): ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату Y(2): ");
double y2 = Convert.ToDouble(Console.ReadLine());
double s = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine($"Расстояние между двумя точками равно {Math.Round(s, 2)}");