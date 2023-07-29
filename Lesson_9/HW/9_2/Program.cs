// Задайте значение М и N. Напишите программу, которая найдет 
// сумму натуральных элементов в промежутке от M до N с помощью рекурсии.

int SumNatural (int A, int B)
{
    if (A == B) return A;
    return SumNatural(A +1, B)+A;

}
Console.WriteLine(SumNatural(3, 5));