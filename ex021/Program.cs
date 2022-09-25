// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


Console.WriteLine("Vvedi koordinatu xa: ");
double xa = double.Parse(Console.ReadLine());

Console.WriteLine("Vvedi koordinatu ya: ");
double ya = double.Parse(Console.ReadLine());

Console.WriteLine("Vvedi koordinatu za: ");
double za = double.Parse(Console.ReadLine());

Console.WriteLine("Vvedi koordinatu xb: ");
double xb = double.Parse(Console.ReadLine());

Console.WriteLine("Vvedi koordinatu yb: ");
double yb = double.Parse(Console.ReadLine());

Console.WriteLine("Vvedi koordinatu zb: ");
double zb = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow((xb-xa),2)+Math.Pow((yb-ya),2)+Math.Pow((zb-za),2));

Console.WriteLine($"Rasstoyanie ravno {Math.Round(d,3)}");
