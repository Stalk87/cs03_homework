//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите через пробел координаты X Y и Z точки A:");
string xyz = Console.ReadLine()!;
string[] parts = xyz.Split(' ');
int xA = int.Parse(parts[0]);
int yA = int.Parse(parts[1]);
int zA = int.Parse(parts[2]);

Console.WriteLine("Введите через пробел координаты X Y и Z точки B:");
xyz = Console.ReadLine()!;
parts = xyz.Split(' ');
int xB = int.Parse(parts[0]);
int yB = int.Parse(parts[1]);
int zB = int.Parse(parts[2]);

double distance = Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2));
Console.WriteLine($"Расстояние между точками A и B = {distance:F3}");