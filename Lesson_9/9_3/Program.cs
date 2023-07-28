// 3. Напишите программу, которая будет принимать на вход число
//    и возвращать сумму его цифр. Использовать рекурсию.

int Sum (int num)
{
    if (num == 0) return 0;
    return Sum(num /10) + num %10;

}
Console.WriteLine(Sum(123));
Console.WriteLine(Sum(1236));