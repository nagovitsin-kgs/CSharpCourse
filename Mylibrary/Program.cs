/*
// 1. Унарный оператор инкремента (++) увеличивает операнд (действие) на 1.
// x++
int i = 3;
Console.WriteLine(i);   // output: 3
Console.WriteLine(i++); // output: 3
Console.WriteLine(i);   // output: 4
// ++x
double a = 1.5;
Console.WriteLine(a);   // output: 1.5
Console.WriteLine(++a); // output: 2.5
Console.WriteLine(a);   // output: 2.5

// 2. Унарный оператор декремента (--) уменьшает операнд на 1.
// x--
double i = 3;
Console.WriteLine(i);   // output: 3
Console.WriteLine(i--); // output: 3
Console.WriteLine(i);   // output: 2
// --x 
double a = 1.5; // double (двойной)
Console.WriteLine(a);   // output: 1.5
Console.WriteLine(--a); // output: 0.5
Console.WriteLine(a);   // output: 0.5

// 3. Унарный оператор (+) возвращает значение полученного операнда, (-) изменяет знак операнда на противоположный.
Console.WriteLine(+4);     // output: 4

Console.WriteLine(-4);     // output: -4
Console.WriteLine(-(-4));  // output: 4

uint a = 5;
var b = -a;
Console.WriteLine(b);            // output: -5
Console.WriteLine(b.GetType());  // output: System.Int64

Console.WriteLine(-double.NaN);  // output: NaN
*/

/*
decimal[] values = { Decimal.MinValue, -1034.23m, -12m, 0m, 147m,
                    199.55m, 9214.16m, Decimal.MaxValue };
int result;

foreach (decimal value in values)
{
    try
    {
        result = Convert.ToInt32(value);
        Console.WriteLine("Converted the {0} value '{1}' to the {2} value {3}.",
                          value.GetType().Name, value,
                          result.GetType().Name, result);
    }
    catch (OverflowException)
    {
        Console.WriteLine("{0} is outside the range of the Int32 type.",
                          value);
    }
}
// The example displays the following output:
//    -79228162514264337593543950335 is outside the range of the Int32 type.
//    Converted the Decimal value '-1034.23' to the Int32 value -1034.
//    Converted the Decimal value '-12' to the Int32 value -12.
//    Converted the Decimal value '0' to the Int32 value 0.
//    Converted the Decimal value '147' to the Int32 value 147.
//    Converted the Decimal value '199.55' to the Int32 value 200.
//    Converted the Decimal value '9214.16' to the Int32 value 9214.
//    79228162514264337593543950335 is outside the range of the Int32 type.
*/
/*
long lNumber = 163245617;
try 
{
   int number1 = (int) lNumber;
   Console.WriteLine(number1);
}
catch (OverflowException) 
{
   Console.WriteLine("{0} is out of range of an Int32.", lNumber);
}

double dbl2 = 35901.997;
try 
{
   int number2 = (int) dbl2;
   Console.WriteLine(number2);
}
catch (OverflowException) 
{
   Console.WriteLine("{0} is out of range of an Int32.", dbl2);
}

// The example displays the following output:
//       163245617
//       35902
*/
/*
string string1 = "244681";
try
{
    int number1 = Int32.Parse(string1);
    Console.WriteLine(number1);
}
catch (OverflowException)
{
    Console.WriteLine("'{0}' is out of range of a 32-bit integer.", string1);
}
catch (FormatException)
{
    Console.WriteLine("The format of '{0}' is invalid.", string1);
}

string string2 = "F9A3C";
try
{
    int number2 = Int32.Parse(string2,
                             System.Globalization.NumberStyles.HexNumber);
    Console.WriteLine(number2);
}
catch (OverflowException)
{
    Console.WriteLine("'{0}' is out of range of a 32-bit integer.", string2);
}
catch (FormatException)
{
    Console.WriteLine("The format of '{0}' is invalid.", string2);
}
// The example displays the following output:
//       244681
//       1022524
*/
/*
// 4. Оператор умножения (*) вычисляет произведение операндов:

Console.WriteLine(5 * 2);         // output: 10
Console.WriteLine(0.5 * 2.5);     // output: 1.25
Console.WriteLine(0.1m * 23.4m);  // output: 2.34

// 5. Оператор деления (/) делит левый операнд на правый.
// 5.1 Деление целых чисел. (/) - после деления берет целое частное число (слева), округленное в сторону нуля:
Console.WriteLine(13 / 5);    // output: 2
Console.WriteLine(-13 / 5);   // output: -2
Console.WriteLine(13 / -5);   // output: -2
Console.WriteLine(-13 / -5);  // output: 2
// Чтобы получить частное двух операндов в виде числа с плавающей запятой, используйте тип float, double или decimal:
Console.WriteLine(13 / 5.0);       // output: 2.6

int a = 13;
int b = 5;
Console.WriteLine((double)a / b);  // output: 2.6
// 5.2 Деление чисел с плавающей запятой. Для типов float, double и decimal результатом оператора / является частное двух операндов:
Console.WriteLine(16.8f / 4.1f);   // output: 4.097561
Console.WriteLine(16.8d / 4.1d);   // output: 4.09756097560976
Console.WriteLine(16.8m / 4.1m);   // output: 4.0975609756097560975609756098
*/
/* Если один из операндов — это decimal, второй операнд не может быть ни float, ни double, так как ни float, ни double 
не преобразуется неявно в тип decimal. Необходимо явным образом преобразовать операнд float или double в тип decimal. 
Дополнительные сведения о числовых преобразованиях см. в разделе Встроенные числовые преобразования.
*/
// 5.3 Оператор остатка % 






//String.Length // Свойство. Возвращает число знаков в текущем объекте String.
/*
string str = "abcdefg";
Console.WriteLine("1) The length of '{0}' is {1}", str, str.Length);
Console.WriteLine("2) The length of '{0}' is {1}", "xyz", "xyz".Length);

int length = str.Length;
Console.WriteLine("3) The length of '{0}' is {1}", str, length);

// This example displays the following output:
//    1) The length of 'abcdefg' is 7
//    2) The length of 'xyz' is 3
//    3) The length of 'abcdefg' is 7
*/