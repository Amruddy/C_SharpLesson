// Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.




// int day = int.Parse(Console.ReadLine()!);
// if (day <= 5 && day > 0)
// {

//     Console.WriteLine("НЕ ВЫХОДНОЙ");
// }
// else if(day > 5 && day < 8) {
//     Console.WriteLine("ВЫХОДНОЙ");
// }
// else
// {
//     Console.WriteLine("НЕТ ТАКОГО ДНЯ");
// }

string a = Console.ReadLine()!;

if (a == "6")
{
    Console.WriteLine("Суббота - выходной");
}
else if (a == "7")
{
    Console.WriteLine("Воскресенье - выходной");
}
else
{
    switch (a)
    {
        case "1":
            Console.WriteLine("Понедельник");
            break;
        case "2":
            Console.WriteLine("Вторник");
            break;
        case "3":
            Console.WriteLine("Среда");
            break;
        case "4":
            Console.WriteLine("Четверг");
            break;
        case "5":
            Console.WriteLine("Пятница");
            break;

        default:
            Console.WriteLine("Не слышал про такой день");
            break;
    }
}
