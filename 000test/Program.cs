/*Задача 47. Задайте двумерный массив размером m×n, 
  заполненный случайными вещественными числами.
   m = 3, n = 4.
   0,5 7 -2 -0,2
   1 -3,3 8 -9,9
   8 7,8 -7,1 9
  */

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




