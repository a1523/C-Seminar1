// Напишите программу, которая будет проверять является ли второе число корнем первого
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(number1, 2));

if (result == number2)
{
    Console.WriteLine ($"Второе число {number2} является корнем первого числа {number1}");
}
else
{
    Console.WriteLine ($"Второе число {number2} не является корнем первого числа {number1}");
}