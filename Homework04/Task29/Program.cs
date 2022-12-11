/*Задача 29: Напишите программу, которая задаёт массив из N элементов (из диапазона [0-14] ) 
и выводит на экран десятичное представление числа, записанного в СС по основанию 15.
N: 3 [9, 4, 12] => 2097
Для проверки можно использовать https://numsys.ru/convert/2097/10/15
*/
// Создание массива
  int[] CreateArray(int count)
  {
    return new int[count];
  }

  // Заполнение числами от 0-14
  void Fill(int[] array)
  {
    for (int i = 0; i < array.Length; i++)
    {
      array[i] = Random.Shared.Next(0, 15);
    }
  }

  // печать массива
  string Print(int[] array)
  {

    string result = String.Empty;
    for (int i = 0; i < array.Length; i++)
    {
      if (array[i] == 10) result += $"A";
      else if (array[i] == 11) result += $"B";
      else if (array[i] == 12) result += $"C";
      else if (array[i] == 13) result += $"D";
      else if (array[i] == 14) result += $"E";
      else result += $"{array[i]}";
    }

    return result;
  }
  
