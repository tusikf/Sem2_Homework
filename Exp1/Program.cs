// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Проверка на трехзначность при вводе пользователем)
// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = 1000;

Console.Write("Введите трехзначное число: ");
number = int.Parse(Console.ReadLine()!);
int kk = number / 100;

while ( kk < 1 || kk > 10)
{
    Console.Write("Введите трехзначное число: ");
    number = int.Parse(Console.ReadLine()!);
    kk = number / 100;
}

int num1 = number % 100;
int num2 = num1 / 10;

Console.WriteLine($"Вторая цифра введенного числа это : { num2 }");