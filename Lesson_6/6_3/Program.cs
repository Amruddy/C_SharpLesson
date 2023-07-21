// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//    Первые два числа Фибоначчи: 0 и 1.

void Fibonachi (int N)
{
    int temp = 0;
    int temp2 = 1;

    for (int i = 0; i < N; i++)
    {
        Console.Write(temp);
        (temp, temp2) = (temp2, temp+ temp2);

    }
}
Fibonachi(2);
