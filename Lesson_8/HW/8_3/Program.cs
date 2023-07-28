// 3. Задайте две матрицы. Напишите программу,
//    которая будет находить произведение двух матриц.


void Print(int[,] arr)
{
    int row_size = arr.GetLength(0);
    int column_size = arr.GetLength(1);

    for (int i = 0; i < row_size; i++)
    {
        for (int j = 0; j < column_size; j++)
            Console.Write($" {arr[i, j],3} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MassNums(int row, int column, int from, int to)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < row; i++)
        for (int j = 0; j < column; j++)
            arr[i, j] = new Random().Next(from, to);
    return arr;
}

int[,] MatrixProduct(int[,] matrixA, int[,] matrixB)
    {
        int rowsA = matrixA.GetLength(0);
        int colsA = matrixA.GetLength(1);
        int rowsB = matrixB.GetLength(0);
        int colsB = matrixB.GetLength(1);

        if (colsA != rowsB)
        {
            throw new ArgumentException("Число столбцов первой матрицы должно быть равно числу строк второй матрицы.");
        }

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;

                for (int k = 0; k < colsA; k++)
                {
                    sum += matrixA[i, k] * matrixB[k, j];
                }

                result[i, j] = sum;
            }
        }

        return result;
    }


Console.Write("Enter the number of rows 1: ");
int rowsA = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns 1: ");
int colsA = int.Parse(Console.ReadLine()!);

Console.Write("Enter the number of rows 2: ");
int rowsB = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns 2: ");
int colsB = int.Parse(Console.ReadLine()!);

int[,] arr_1 = MassNums(rowsA, colsA, 1, 10);
Print(arr_1);
int[,] arr_2 = MassNums(rowsB, colsB, 1, 10);
Print(arr_2);

int[,] result_matrix = MatrixProduct(arr_1, arr_2);
Print(result_matrix);