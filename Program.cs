// Задача 4: Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число от 1 до 7 обозначающее день недели");

string day = Console.ReadLine();

if (day != "1" && day != "2" && day != "3" && day != "4" && day != "5" && day != "6" && day != "7")
{
    Console.WriteLine("Нет такого дня недели"); // все числа кроме 1, 2, 3, 4, 5, 6, 7
}

if (day == "1")
{
    Console.WriteLine("Понедельник не является выходным днём");
}
if (day == "2")
{
    Console.WriteLine("Вторник не является выходным днём");
}
if (day == "3")
{
    Console.WriteLine("Среда не является выходным днём");
}
if (day == "4")
{
    Console.WriteLine("Четверг не является выходным днём");
}
if (day == "5")
{
    Console.WriteLine("Пятница не является выходным днём");
}
if (day == "6")
{
    Console.WriteLine("Суббота выходной день");
}
if (day == "7")
{
    Console.WriteLine("Воскресенье выходной день");
}
