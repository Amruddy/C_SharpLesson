// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
int Count(int num)
{
    int result = 0;
    for (int i = 1; num != 0; i++)
    {
        int digit = num % 10;
        result += digit;
        num /= 10;
    }
    return result;
}

int A = int.Parse(Console.ReadLine());
int result = Count(A);
Console.WriteLine(result);
