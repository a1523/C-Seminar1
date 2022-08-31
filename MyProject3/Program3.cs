// Напишите программу, которая будет выдавать название дня недели по заданному номеру
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine($"Числу {number} соответствует день недели - понедельник");
}
if (number == 2)
{
    Console.WriteLine($"Числу {number} соответствует день недели - вторник");
}
if (number == 3)
{
    Console.WriteLine($"Числу {number} соответствует день недели - среда");
}
if (number == 4)
{
    Console.WriteLine($"Числу {number} соответствует день недели - четверг");
}
if (number == 5)
{
    Console.WriteLine($"Числу {number} соответствует день недели - пятница");
}
if (number == 6)
{
    Console.WriteLine($"Числу {number} соответствует день недели - суббота");
}
if (number == 7)
{
    Console.WriteLine($"Числу {number} соответствует день недели - воскресенье");
}
if (number > 7)
{
    Console.WriteLine($"Числу {number} не соответствует ни один день недели");
}
