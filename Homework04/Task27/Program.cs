/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/
// --- Вариант №1: ---
/*
Console.WriteLine("Введите число");

int Number = Convert.ToInt32(Console.ReadLine());

int Sum = 0;

while (Number > 0)
{
int Temporary = Number % 10;    // делим и берём остаток после запятой.
Number = Number / 10;           // делим и берём целое число до запятой (впереди). 
Sum = Sum + Temporary;          // находим, суммируем и запоминаем сумму прошлую  и остатков от целого числа.
}
Console.WriteLine($"Сумма всех цифр в числе: Sum = {Sum}");
*/

// --- Вариант №2: ---
/*
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);


// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}
*/
