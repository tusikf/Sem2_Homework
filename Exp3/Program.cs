﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите номер дня недели ( от 1 до 7 ) : ");
int number = int.Parse(Console.ReadLine()!);

if ( number == 6 || number == 7 )
{
    Console.WriteLine("Введенный номер дня недели это выходной ");
}
else
{
    if (number < 1 || number > 7 )
    {
       Console.WriteLine("Дня недели с введенным номером не существует. ");
    }
    else
    {
       Console.WriteLine("Введенный номер дня недели это не выходной"); 
    }
}