
Console.WriteLine("Start"); // start

Console.WriteLine("Введите пятизначное число: "); // вводим число
string number = Console.ReadLine(); // читаем следующей строкой number на консоли

int len = number.Length; // длинна = количеству цифр

if (len == 5) // оператор if через условие если длина = 5, то истина или ложь
{
    if (number[0] == number[4] && number[1] == number[3]) // Если в числе пятизначном первая цифра = последней и вторая = предпоследней, то палиндром, если нет, то не палиндром 
    {
        Console.WriteLine($"{number} - является палиндромом"); // вывод на консоли - истина
    }
    else
    {
        Console.WriteLine($"{number} - не является палиндромом"); // вывод на консоли - ложь
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным значением, повтори попытку занова"); // вывод на консоли ложь введенного числа
}
Console.WriteLine("End");


/*string str = "abcdefg";
Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);

int length = str.Length;
Console.WriteLine("'{0}' {1}", str, length);
*/