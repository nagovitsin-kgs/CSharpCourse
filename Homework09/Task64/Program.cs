/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"   */

Console.Clear();

int n = InputInt("Введите положительное число: n = ");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int m = 1;
int NaturalNumber(int n, int m)
{
    while (n < 1)
    {
        {
            Console.WriteLine("Вы ввели не положительное число, попробуйте запустить программу ещё раз и ввести верное число! ");
            return int.Parse(Console.ReadLine());
        }
    }
    if (n == m)
    {
        return n;
    }
    else
    {
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
        return m;
    }
}

Console.WriteLine(NaturalNumber(n, m));

