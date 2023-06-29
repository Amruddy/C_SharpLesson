void Crat(int num)
{
if (num % 7 == 0 && num % 23 == 0)
{
Console.WriteLine("Да");
}
else
{
Console.WriteLine("Нет");
}

}

int numA = int.Parse(Console.ReadLine()!);
Crat(numA);