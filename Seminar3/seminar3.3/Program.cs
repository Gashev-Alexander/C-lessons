﻿Console.Clear();
Console.WriteLine("Введите координаты точки А:");
int xA = int.Parse(Console.ReadLine());
int yA = int.Parse(Console.ReadLine());
int zA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B:");
int xB = int.Parse(Console.ReadLine());
int yB = int.Parse(Console.ReadLine());
int zB = int.Parse(Console.ReadLine());
double num = Math.Pow((xB-xA), 2) + Math.Pow((yB-yA), 2) + Math.Pow((zB-zA), 2);
double AB = Math.Sqrt(num);
Console.Write($"Длина отрезка => {AB.ToString("0.000")}");

// программа переписана для вычесления растояния между двумя точка в 3D простанстве