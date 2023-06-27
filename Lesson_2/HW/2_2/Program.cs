// Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.


int TakeTh(int num)
{
    Console.WriteLine(num);

    if (num < 100)
    {
        Console.WriteLine("Третей цифры нет");
        return -1;
    }
    else if (num > 99 && num < 1000)
    {
        return num % 10;
    }
    else
    {
        
        while (num > 999)
        {
            num = num / 10;
        }
        return num % 10;
    }


}

int thnum = int.Parse(Console.ReadLine()!);
int result = TakeTh(thnum);

Console.WriteLine(result);

