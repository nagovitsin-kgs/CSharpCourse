/* Задача 52. Задайте двумерный массив из целых чисел. 
   Найдите среднее арифметическое элементов в каждом столбце.
   Например, задан массив:    
   1 4 7 2
   5 9 2 3
   8 4 2 4
   Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

// 1. Вввод количества строк и столбцов с клавиатуры для создания двумерного массива.
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

// 2. Создание двумерного массива.
int[,] numbers = new int[m, n];
FillArray2DRandomNumbers(numbers);
// 3. Расчёт среднего арифметического в каждом столбце.
for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / m;
    Console.Write(avarage + "; ");
}
Console.WriteLine();
PrintArray2D(numbers);

// 4. Метод заполнения двумерного массива случайными целыми числами.
void FillArray2DRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

// 5. Метод печати двумерного массива.
void PrintArray2D(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
