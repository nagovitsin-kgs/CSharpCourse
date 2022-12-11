/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
// --- Вариант №1: ---
/*
Console.WriteLine("Введите число A: ");

int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");

int B = Convert.ToInt32(Console.ReadLine());
int step = 1;

for (int i = 0; i < B; i++)
{
step = step * A;
}
Console.WriteLine($"A^B = {step}");
*/

// --- Вариант №2:---

/*
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");

ToDegree(numberA, numberB);

        // Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}
     // Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/
/*
// --- Вариант №3 ---
int A;
int B;
Console.WriteLine("Ввести число A: ");
A = int.Parse(Console.ReadLine());

Console.WriteLine("Ввести число B: ");
B = int.Parse(Console.ReadLine());
int Composition = 1;
for (int i = 0; i < B; i++)
{
    Composition = Composition * A;
}
Console.WriteLine(Composition);
*/