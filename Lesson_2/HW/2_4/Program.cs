// Напишите программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

int num = new Random().Next(100, 1000);
Console.WriteLine(num);
int num1 = num / 100;
// Console.WriteLine(num1);
int num2 = num % 10;
// Console.WriteLine(num2);
int sum = (num1 * 10) + num2;
Console.WriteLine(sum);