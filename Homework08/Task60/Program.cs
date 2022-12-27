/* Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0, 0, 0)  25(0, 1, 0)
34(1, 0, 0)  41(1, 1, 0)
27(0, 0, 1)  90(0, 1, 1)
26(1, 0, 1)  55(1, 1, 1)    */

Console.Clear();

int dimension1 = InputInt("Введите размерность 1: ");
int dimension2 = InputInt("Введите размерность 2: ");
int dimension3 = InputInt("Введите размерность 3: ");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int countNumbers = 89;

if (dimension1 * dimension2 * dimension3 > countNumbers)
{
    Console.Write("Массив слишком большой");
    return;
}

int[,,] resultNumbers = Create3DMassive(dimension1, dimension2, dimension3);

for (int i = 0; i < resultNumbers.GetLength(0); i++)
{
    for (int j = 0; j < resultNumbers.GetLength(1); j++)
    {
        for (int k = 0; k < resultNumbers.GetLength(2); k++)
        {
            Console.WriteLine($"[{i},{j},{k}] - {resultNumbers[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] Create3DMassive(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];

    int[] values = new int[countNumbers];

    int num = 10;

    for (int i = 0; i < values.Length; i++)
        values[i] = num
        ++;

    for (int i = 0; i < values.Length; i++)
    {
        int randomInd = new Random().Next(0, values.Length);
        int temp = values[i];
        values[i] = values[randomInd];
        values[randomInd] = temp;
    }

    int valueIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = values[valueIndex++];
            }
        }
    }
    return array;
}