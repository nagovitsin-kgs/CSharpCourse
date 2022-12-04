/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
*/

int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));


int ReadInt(string message) // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int MakeArray(int a, int b) // Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
{
int result = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет: Пусто: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}