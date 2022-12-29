/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии!
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"   */

//      Декомпозиция:
// 1. Метод ввода натурального числа.
// 2. Метод расчёта натуральных чисел в промежутке от N до 1.
// 3. Метод всех методов и печати на экран.

Console.Clear();

// 1. Метод ввода натурального числа от N до 1.
int InputNaturalNumber(out int n)
{
    Console.Write("Введите натуральное число: n = ");
    n = Convert.ToInt32(Console.ReadLine());
    return n;
}

// 2. Метод расчёта натуральных чисел в промежутке от N до 1.
int NaturalNumbersToBetweenRecursion(int n, int m)
{
    while (n < 1)
    {
        Console.WriteLine("Это не натуральное число. Натуральные числа - это числа, которые мы употребляем при счёте. Они только положительные. Попробуйте запустить программу ещё раз и ввести верное число! ");
        return int.Parse(Console.ReadLine());
    }
    if (n == m)
    {
        return n;
    }
    {
        Console.Write($"{NaturalNumbersToBetweenRecursion(n, m + 1)}, ");
        return m;
    }
}

// 3. Метод всех методов и печати на экран.
void MethodEveryoneMethods()
{
    int n = InputNaturalNumber(out n);

    int m = 1;
    Console.WriteLine(NaturalNumbersToBetweenRecursion(n, m));
}

MethodEveryoneMethods();