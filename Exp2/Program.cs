// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число от 1 до 100 000 : ");
int number = int.Parse(Console.ReadLine()!);

while (  number < 1 || number > 100000)
{
    Console.Write("Введите число от 1 до 100 000 : ");
    number = int.Parse(Console.ReadLine()!);
}

int num1 = number % 1000 / 100;

if ( num1 ==0 && number < 100)
{
    Console.Write("В введенном числе нет третьей цифры ");
}
else
{
    Console.WriteLine($"Третья цифра введенного числа это : { num1 }");
}

