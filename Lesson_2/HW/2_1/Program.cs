// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.



int TakeNum(int num)
{
    Console.WriteLine(num);

    return (num / 10) % 10;
}
int sec_num = new Random().Next(100, 1000);
int result = TakeNum(sec_num);
Console.WriteLine(result);
// 123 % 10 -> 3
// 123 % 100 -> 23

// 123 / 10 -> 12
// 123 / 100 -> 1