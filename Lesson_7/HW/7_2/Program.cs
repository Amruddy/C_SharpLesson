//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] myArray = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        Console.Write("Введите позицию элемента в формате 'строка,столбец': ");
        string input = Console.ReadLine();

        if (TryParsePosition(input, out int row, out int col))
        {
            int? element = GetElementAtPosition(myArray, row, col);

            if (element.HasValue)
                Console.WriteLine($"Значение элемента [{row}, {col}]: {element}");
            else
                Console.WriteLine($"Элемента с позицией [{row}, {col}] в массиве нет.");
        }
        else
        {
            Console.WriteLine("Указана некорректная позиция. Введите позицию в формате 'строка,столбец'.");
        }
    

    // Метод для разбора введенной позиции в формате 'строка,столбец'
    static bool TryParsePosition(string input, out int row, out int col)
    {
        string[] parts = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 2 && int.TryParse(parts[0], out row) && int.TryParse(parts[1], out col))
        {
            return true;
        }
        else
        {
            row = col = -1; // Указание на некорректные значения
            return false;
        }
    }

    // Метод для получения элемента по заданным координатам в двумерном массиве
    static int? GetElementAtPosition(int[,] arr, int row, int col)
    {
        int rows = arr.GetLength(0);
        int cols = arr.GetLength(1);

        if (row >= 1 && row <= rows && col >= 1 && col <= cols)
        {
            return arr[row - 1, col - 1];
        }
        else
        {
            return null; // Указание на отсутствие элемента
        }
    }