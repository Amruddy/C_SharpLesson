﻿// 4. Напишите программу, которая на вход принимает два числа A и B,
//    и возводит число А в целую степень B с помощью рекурсии.

int Rec(int A, int B)
{
    if (B == 0) return 1;

    return Rec(A, B-1)*A;
}
Console.WriteLine(Rec(3, 3));