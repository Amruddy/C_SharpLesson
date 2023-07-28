// Задайте значения M и N. Напишите программу, которая выведет все чётные
// натуральные числа в промежутке от M до N с помощью рекурсии.

void PrintEvenNumbersInRange(int m, int n)
{
    if (m > n) return;

    if (m % 2 == 0)
    {
        Console.WriteLine(m);
    }


    PrintEvenNumbersInRange(m + 1, n);
}

PrintEvenNumbersInRange(1, 10);