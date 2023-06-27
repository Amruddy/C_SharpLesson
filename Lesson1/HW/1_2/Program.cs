//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
int c = int.Parse(Console.ReadLine()!);

int max = Math.Max(a, Math.Max(b, c));
Console.WriteLine("Максимальное число: " + max);






