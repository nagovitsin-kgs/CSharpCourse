public class MyLibrary
{
    // Создание массива
    public static int[] CreateArray(int count)
    {
        return new int[count];
    }

    // Заполнение числами от 0-14
    public static void Fill(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Shared.Next(0, 15); // new Random().Next(0, 15)
        }
    }

    // Печать массива 1 Вариант:
    public static string Print01(int[] array)
    {
        string result = string.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            result += $"{array[i]}";
        }
        return result;
    }

    // Печать массива 2 Вариант:

    public static string Print02(int[] array)
    {
        return string.Join(" ", array);
    }

    // Печать массива 3 Вариант:

    public static string Print03(int[] array)
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

    // Возведение числа в степень (a^b =  a*a*a*...*a)  b раз
               
    public static int Pow(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result = result * a;
        }
        return result;
    }

    // Написать конвертор из 15-ой в 10-ую

    //  0  1  2   3
    // [6, 4, 3, 10]
    //  3  2  1   0
    // 10 * 15^0 + 3 * 15^1 + 4 * 15^2 + 6 * 15^3

    public static int ToDec(int[] value)
    {
        int result = 0;
        int count = value.Length;

        for (int i = 0; i < count; i++)
        {
            result += value[i] * Pow(15, count - 1 - i);
        }
        return result;
    }

    // Написать сумму ЦИФР числа:
    public static int SumNumberIn(int value)
    {
        int r = 0;

        while (value != 0)
        {
            r += value % 10;
            value = value / 10;
            // value /= 10;
        }
        return r;
    }
}

// Введите размерность массива от 1 до 19 включительно: 5

// Введите основание системы счисления: 12
// 9 * 12⁴ +6 * 12³ +4 * 12² +7 * 12ⁱ + 4 * 12⁰
// 96474₁₂ = 197656₁₀
// 