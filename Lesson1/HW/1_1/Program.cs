 int a = int.Parse(Console.ReadLine()!);
 int b = int.Parse(Console.ReadLine()!);
if (b < a)
{
    Console.WriteLine("{0} > {1}", a, b);
}
else if (b > a) 
{
    Console.WriteLine("{0} > {1}", b, a);
    
}
    else {
        Console.WriteLine("равны");
    }