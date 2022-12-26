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
// 5. Метод нахождения суммы элементов массива в строке.
// 6. Метод нахождения строки в двумерном массиве с ниименьшей суммой элементов с объявлением номера строки.
// 7. Метод вызова всех методов.
// 8. Вызов метода всех методов (запуск программы).

Console.Clear();

// 1. Метод введения с клавиатуры прямоугольного двумерного массива.

void InputWithKeyboardsDimensionSquareArray(out int DimensionSquare)
{
    Console.Write("Введите с клавиатуры размерность квадратного массива DimensionSquare = ");
    DimensionSquare = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
}

int DimensionSquare;
InputWithKeyboardsDimensionSquareArray(out DimensionSquare);

// 2. Метод создания двумерного массива.
int[,] CreateArray2D(int rows, int columns)
{
    return new int[rows, columns];
}

int[,] matrix = CreateArray2D(DimensionSquare, DimensionSquare);

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

FillArray2DRandomNumbers(matrix);

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

PrintArray2D(matrix);

// 5. Метод нахождения суммы элементов массива в строке.
int FindingAmountsElementsToRowsArray2D(int[,] arr)
{
    int amount = 0;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            amount = amount + arr[i, j];
        }
        Console.WriteLine($"Сумма строки в массиве: amount{i} = {amount}; ");
    }
    Console.WriteLine();
    return amount;
}

FindingAmountsElementsToRowsArray2D(matrix);

// 6. Метод нахождения строки в двумерном массиве с ниименьшей суммой элементов с объявлением номера строки.

int i = 0;
int indexRow = 0;
int minAmount = amount[i];
if (amount[i] < min)
{
    minAmount = amount[i];
    indexRow++;
}




/*
Console.WriteLine("введите размер квадратного массива");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massVol, massVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);



void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
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







int minsum = Int32.MaxValue;
int indexLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexLine++;
    }
}

Console.WriteLine("строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));
*/