/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка. */

//      Декомпозиция:
// 1. Метод введения с клавиатуры прямоугольного двумерного массива.
// 2. Метод создания двумерного массива.
// 3. Метод заполнения двумерного массива случайными целыми числами.
// 4. Метод печати двумерного массива на экран.
// 5. Метод нахождения строки в двумерном массиве с наименьшей суммой элементов и с объявлением номера строки.
// 6. Метод вызова всех методов.
// 7. Вызов метода всех методов (запуск программы).

Console.Clear();

// 1. Метод введения с клавиатуры прямоугольного двумерного массива.
void InputWithKeyboardsDimensionSquareArray(out int DimensionSquare)
{
    Console.Write("Введите с клавиатуры размерность квадратного массива DimensionSquare = ");
    DimensionSquare = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

// 2. Метод создания двумерного массива.
int[,] CreateArray2D(int rows, int columns)
{
    return new int[rows, columns];
}

// 3. Метод заполнения двумерного массива случайными целыми числами.
void FillArray2DRandomNumbers(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(0, 10);
        }
    }
}

// 4. Метод печати двумерного массива на экран.
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
    Console.WriteLine();
}

// 5. Метод нахождения строки в двумерном массиве с наименьшей суммой элементов и с объявлением номера строки.
int FindingMinimumAmountsElementsToRowsArray2D(int[,] arr)
{
    int amount = 0;
    int minimumAmount = int.MaxValue;
    int lineNumber = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            amount = amount + arr[i, j];
        }
        Console.WriteLine($"Сумма {i} строки в массиве: amount{i} = {amount}; ");
        if (amount < minimumAmount)
        {
            minimumAmount = amount;
            lineNumber++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"В строке с номером {lineNumber - 1} наименьшая сумма = {minimumAmount}. ");
    Console.WriteLine();
    return amount;
    return lineNumber;
}

// 6. Метод вызова всех методов.
void ChallengeEveryoneMethods()
{
    int DimensionSquare;
    InputWithKeyboardsDimensionSquareArray(out DimensionSquare);

    int[,] matrix = CreateArray2D(DimensionSquare, DimensionSquare);

    FillArray2DRandomNumbers(matrix);

    PrintArray2D(matrix);

    FindingMinimumAmountsElementsToRowsArray2D(matrix);
}

// 7. Вызов метода всех методов (запуск программы).
ChallengeEveryoneMethods();