// Напишите программу, к-я на вход принимает число (N), а на выходе показывает все целые числа в промежуьке от -N до N

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

// Определяем противоположное число. Что бы учесть вариант, что пользователь уже внес число со знаком "-", используем 
// библиотеку Math и функцию Abs (взятие числа по модулю)
int startNumber = Math.Abs(number) * -1;

while (startNumber <= number) {
    Console.WriteLine(startNumber);
    startNumber = startNumber + 1;
}
