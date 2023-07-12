// Напишите программу, которая задаёт массив 
// и выводит их на экран.

Console.WriteLine("Введите длину массива:");
int length = int.Parse(Console.ReadLine()!);
int[] array = new int[length];
Random random = new Random();

for (int i = 0; i < length; i++)
{
    array[i] = random.Next(1, 10);
}
Console.Write("[");
for (int i = 0; i < length; i++)
{
    Console.Write(array[i]);
    if (i < length - 1)
    {
        Console.Write(" ");
    }
}
Console.WriteLine("]");

