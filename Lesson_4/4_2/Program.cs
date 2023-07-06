// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.

int MultiplyNum(int num)
{
    int product = 1;
    for (int i = 1; i <= num; i++)
        product *= i;

    return product;    
}

int A = int.Parse(Console.ReadLine()!);
int result = MultiplyNum(A);
Console.WriteLine(result);
