// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.


Random random = new Random();

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();
}

int[] array = new int[6];
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 70);
}

int sum = 0;
for (int i = 1; i < array.Length; i += 2)
{
    sum += array[i];
}
Print(array);
Console.WriteLine("Сумма чисел нечетных позициях: " + sum);