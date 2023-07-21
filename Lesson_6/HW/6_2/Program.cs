//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

 Console.WriteLine("Введите значения k1, b1, k2 и b2 для уравнений y = k1 * x + b1 и y = k2 * x + b2:");

        Console.Write("k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("k2: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.Write("b2: ");
        double b2 = double.Parse(Console.ReadLine());

        double xIntersection = FindXIntersection(k1, b1, k2, b2);
        double yIntersection = k1 * xIntersection + b1;

        Console.WriteLine($"Точка пересечения: ({xIntersection}, {yIntersection})");
    

    static double FindXIntersection(double k1, double b1, double k2, double b2)
    {
        // Решаем уравнение k1 * x + b1 = k2 * x + b2 для x
        double xIntersection = (b2 - b1) / (k1 - k2);
        return xIntersection;
    }