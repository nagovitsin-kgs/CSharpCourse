/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
   и возвращает значение этого элемента или же указание, что такого элемента нет.
   Например, задан массив:
   1 4 7 2
   5 9 2 3
   8 4 2 4
   17 -> такого числа в массиве нет  */

// 1. Ввод количества строк и столбцов для создания массива.
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

// 2. Создаем массив из строк 10 и стобцов 10.
int [,] numbers = new int [10,10];

// 3. Проверка условия заданных строк с клавиатуры со строками в двумерном массиве, аналогично и со столбцами.
if (m > numbers.GetLength(0) || n > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"Возврат значения элемента {m} строки и {n} столбца равно {numbers[m-1,n-1]}");
}

// 4. Метод заполнения массива случайными целыми числами.
void FillArray2DRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(-100, 100);
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
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}

// 6. Вывод методов на экран.
FillArray2DRandomNumbers(numbers);
PrintArray2D(numbers);