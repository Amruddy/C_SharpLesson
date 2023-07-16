// Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

double[] array = { 5.3, 2.8, 7.1, 9.6, 4.2, 6.9 };

double max = array[0];
double min = array[0];
for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }

    if (array[i] < min)
    {
        min = array[i];
    }
}
double difference = max - min;


Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);