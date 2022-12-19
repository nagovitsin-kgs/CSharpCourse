/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
   m = 3, n = 4.
   0,5 7 -2 -0,2
   1 -3,3 8 -9,9
   8 7,8 -7,1 9   
*/
// 1. Введём количество строк и столбцов с клавиатуры.
Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

// 2. Создадим двумерный массив.
double[,] numbers = new double[m, n];

// 3. Метод заполнения случайными числами.
void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}
// 4. Метод печати двумерного массива.
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine(" ");
    }
}

// 5. Вызов методов.
//double[,] numbers = new double[m, n]; 
FillArrayRandomNumbers(numbers);
PrintArray(numbers);