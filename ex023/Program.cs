// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введи число: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i<=n; i++)
{
    int cubn = Convert.ToInt32(Math.Pow(i,3));
    Console.WriteLine(cubn);
}
