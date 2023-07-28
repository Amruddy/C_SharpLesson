// 2. Задайте прямоугольный двумерный массив. Напишите программу,
//    которая будет находить строку с наименьшей суммой элементов.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],4} ");
        Console.WriteLine();
    }
    Console.WriteLine();

}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to + 1);

    return arr;
}

void FindRowWithMinSum(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);
    double amount = double.PositiveInfinity;
    int num;
    int smallest = 0;

    for (int i = 0; i < row_size; i++)
    {   
        num = 0;
        for (int j = 0; j < column_size; j++)
            num += arr[i, j];
            Console.Write($"{num, 4} ");            

        if (amount > num)
        {
            amount = num;
            smallest = i;
        }
    }
    Console.WriteLine();
    Console.Write($"Строка с наименьшей суммой элементов:  {smallest + 1}");
}
Console.Write("Количество строк: ");
int row = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов: ");
int column = int.Parse(Console.ReadLine());

int[,] arr_1 = MassNums(row, column, 0, 10);
Print(arr_1);

FindRowWithMinSum(arr_1);

