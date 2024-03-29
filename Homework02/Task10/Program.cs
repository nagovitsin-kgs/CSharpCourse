﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine(InCenter(number));
}


int ReadInt(string message) // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int InCenter(int a) // Функция вывода цифры стоящей в середине трехзначногно числа.
{
    
    int result = ((a / 10) % 10);
    return result;
}