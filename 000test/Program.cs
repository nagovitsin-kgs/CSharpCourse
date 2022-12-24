/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
   и возвращает значение этого элемента или же указание, что такого элемента нет.
   Например, задан массив:
   1 4 7 2
   5 9 2 3
   8 4 2 4
   17 -> такого числа в массиве нет  */
Console.Clear();

int m, n;

NewMethod(out m, out n);

// if (x < numbers)   
// {
// Console.Write($"Введите номер столбца {x}" );
// Console.Write($"Введите номер строки {y}" );
// }
int[,] numbers = new int[m, n];

void FillArray2DRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

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

int ReturnValueElement(int[,] matr)
{
    int valueElement = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            valueElement = matr[matr.GetLength(1) - 1, matr.GetLength(1) - 1];

        }
    }
    Console.Write(valueElement);
    return valueElement;
    
}

FillArray2DRandomNumbers(numbers);
PrintArray2D(numbers);
ReturnValueElement(numbers);

void NewMethod(out int m, out int n)
{
    Console.Write("Введите количество строк m: ");
    m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов n: ");
    n = Convert.ToInt32(Console.ReadLine());
}






































/*Задача 47. Задайте двумерный массив размером m×n, 
  заполненный случайными вещественными числами.
   m = 3, n = 4.
   0,5 7 -2 -0,2
   1 -3,3 8 -9,9
   8 7,8 -7,1 9
  */
/*
//Декомпозиция:
// 0. Метод ввода строк и столбцов с клавиатуры.
// 1. Метод создания двумерного массива.
// 2. Метод заполнения двумерного массива случайными числами.
// 3. Метод вывода двумерного массива на экран.

// 0. Метод ввода строк и столбцов с клавиатуры.
void InputWithKeyboardRowsСolumns()
{
    Console.Write("Введите количество строк m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите количество столбцов n: ");
    int n = Convert.ToInt32(Console.ReadLine());
    return m; n;  
}

// 1. Метод создания двумерного массива.


// 2. Метод заполнения двумерного массива случайными числами.
void Fill2DArrayRandomNumbers(double[,] arr2D)
{
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; arr2D.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(Random().Next(-100, 100)) / 10 ;
        }
    }
}

// 3. Метод вывода двумерного массива на экран.
void PrintArray2D(double[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + " ");
        }
            Console.Write("]");
            Console.WriteLine(" ");
    }
}
//InputWithKeyboardRowsСolumns();
double[,] Array2D = new double[InputWithKeyboardRowsСolumns()];
Fill2DArrayRandomNumbers(Array2D);
PrintArray2D(Array2D);
*/



