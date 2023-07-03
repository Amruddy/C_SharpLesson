//Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.


        Console.WriteLine("Введите пятизначное число:");
        string input = Console.ReadLine();

        if (input.Length != 5)
        {
            Console.WriteLine("Введено некорректное число. Пожалуйста, введите пятизначное число.");
            return;
        }

        bool isPalindrome = IsPalindrome(input);
        if (isPalindrome)
        {
            Console.WriteLine("Введенное число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенное число не является палиндромом.");
        }
    

    static bool IsPalindrome(string number)
    {
        for (int i = 0; i < number.Length / 2; i++)
        {
            if (number[i] != number[number.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }
