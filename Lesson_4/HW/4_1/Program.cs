// Напишите цикл, который принимает на вход два числа 
// (A и B) и возводит число A в натуральную степень B.

int Pow(int A, int B)
{
    int result = 1;

    for (int i = 1; i <= B; i++)
    {
        result *= A;
    }
    return result;


}
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);

int result = Pow(A, B);
Console.WriteLine(result);

