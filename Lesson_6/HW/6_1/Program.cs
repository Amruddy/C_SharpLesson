// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

 Console.Write("Введите количество чисел (M): ");
        int M = int.Parse(Console.ReadLine());

        int countPositive = 0;

        for (int i = 0; i < M; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                countPositive++;
            }
        }

        Console.WriteLine($"Количество чисел больше 0: {countPositive}");
    