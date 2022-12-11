﻿
// --- ФУНКЦИИ В ПРОГРАММИРОВАНИИ ---
// double f(double x)  в начале double это возвращаемый ТИП, в скобках double это ТИП аргумента, x это ИМЯ аргумента.
/*
 Void - означает пустоту, "ничего". Использование слова void перед именем метода означает, что, 
 когда завершается выполнение метода, возвращается пустое значение, то есть по завершении определенных действий, 
 которые выполняет метод, он никаких значений не возвращает.
*/

// --- Вид 1.--- Функции в программировании. Метод 1. Ничего не принимают, ничего не возвращают.

void Method1()                                                   // void - это индификатор - пустота, пробел, вакум --ничего не принимает.
{
    Console.WriteLine("Автор: Наговицин Алексей Васильевич");    // тело метода.
}
//Method1();                                                       // вызвали данный метод.


// --- Вид 2.--- Функции в программировании. Метод 2. Что-то принимают, ничего не возвращают.

void Method2(string msg)                             // допустим принимает аргументы 
{
    Console.WriteLine(msg);                         // выводим на консоль те аргументы, которые были приняты.
}
//Method2("Текст сообщения");                        // чтобы вызвать данный метод, требуется указать его интефикатор и текс сообщения.

// --- Пример Метод 2.1 ---               // нужно, если метод принимает количество аргументов.------------

void Method21(string msg, int count)             // допустим принимает аргументы 
{
    int i = 0;                                  // исполльзуется определенное количество msg, которые будут передаваться в наш метод. 
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;                                   // увеличение инкремента на 1.
    }
}
// Method21(msg: "Текст", count: 4);              // либо так - вызываем метод и указываем количество, сколько хотим увидеть раз текст.
// Method21("Текст", 4);                          // либо так вызываем, работает.
//Method21(count: 4, msg: "Новый текст");             // либо так.


// Вид 3. Функции в программировании. Метод 3. Ничего не принимают, что-то возвращают.

int Method3()           // Арг-ты метод не принимает. Если метод что-то возвращает, то указываем Тип Данных Значение которого мы ожидаем.
{
    return DateTime.Now.Year;     // возвращаем (что произошло) ГОД СЕЙЧАС
}
int year = Method3();         // В переменну year ложим наш метод, где, что-то произошло (в resturn).
//Console.WriteLine(year);      // выводим на консоль метод (ГОД сейчас).


/*
  char — это псевдоним для типа структуры System.Char .NET, представляющий символ UTF-16 в Юникоде.
  Значение по умолчанию для типа char — \0, то есть U+0000.
  Тип char поддерживает сравнение, проверку равенства, а также операции инкремента и декремента. 
  Кроме того, для операндов char арифметические и побитовые логические операторы выполняют операцию 
  с соответствующими кодами символов и создают результат типа int.
  
  Тип string представляет текст как последовательность значений char.
  Строка — это объект типа. String, значением которого является текст. Внутри программы текст хранится 
  в виде упорядоченной коллекции объектов Char только для чтения. В конце строки C# нет нуль-символов. 
  Поэтому строка C# может содержать любое число внедренных нуль-символов ('\0'). 
  Свойство. Length строки соответствует числу содержащихся в ней объектов. 
*/
// --- 4 групп (вид 4) это самая используемая...
// Вид 4. Функции в программировании. Метод 4. Что-то принимают, что-то возвращают.

//string Method4(int count, char c)          // будем возвращать строку
string Method4(int count, string text)
{
    int i = 0;
    // string result = "";          // можно так - в результат ложим какое-то значение
    string result = String.Empty;   // result будет у нас пустой строкой, чтобы всем было понятно.

    while (i < count)       // Цикл Вайл (пока)
    {
        result = result + text;
        i++;                       // не забываем увеличивать наш счётчик (инкремент).
    }
    return result;                 //  после того, как метод отработаем указываем результат, который нужно вернуть. Значение, которое мы ожидаем получить из метода.
}
string res = Method4(10, "Z"); // вызовим метод. Функция отработает и выдаст результат. Введем количество раз и текст и положим это в переменную.
//Console.WriteLine(res);

/*
// --- Цикл for ---
   Цикл for является структурой повторного управления, которая позволяет эффективно написать цикл, 
   который нужно выполнить определенное количество раз.
for (int i = 0; i < 10; i++)     
{
    Console.WriteLine(i);
}
*/
// --- продолжение метода 4 с помощью цикла for --- копируем выше данные...

string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "Z");
//Console.WriteLine(res);

// для информаци все циклы взаимозаменяемые...

// --- Цикл for в цикле for --- оператором для первого цикла будет являться тело второго цикла.
/*
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(i*j);
    }
    Console.WriteLine();
}
*/
// Задача выведем таблицу умножения на консоль. Таблица умножения начинается с 2.

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        //Console.WriteLine($"{i} х {j} = {i * j}");    // интерполяция строк - тело вторго цикла будет произведение.
    }
    // Console.WriteLine();    // после как тело цикла отработает, делаем разрыв строки на консоле (между циклами и таблицей умножения)
}

// ===== Работа с текстом . --- Функции в программировании ---
/*
Дан текст. В тексте нужно все пробелы заменить палочками (|),
маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.
Ясна ли задача?
Что значит “Дан текст”?.
Что значит “черточками”?
Какого алфавита?
Маленькие буквы “к” заменить большими “К”, а большие “С” заменить
маленькими “с”.
Ясна ли задача?
Да. Текст:
— Я думаю, — сказал князь, улыбаясь, — что,
ежели бы вас послали вместо нашего милого
Винценгероде, вы бы взяли приступом согласие
прусского короля. Вы так красноречивы. Вы
дадите мне чаю?
В языке C# оператор присваивания обозначается символом равенства – “=”, 
и имеет следующий синтаксис:< тип данных> <имя переменной> = <значение> в случае, когда создается новая переменная, 
или< переменная> = <значение>, коли переменной присваивается новое значение.
== это совпал.
*/

string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// дадим пояснение
// string s = "qwerty"; 
//             012345      // чтобы обратиться к конкретному символу строки, начинаем с 0.
// s[3]  // r              // чтобы получить символ, указываем индефикатор s и в квадратных скобках указываем номер символа.
// Зная это пишем код:

string Replace(string text, char oldValue, char newValue)  // Replace (заменить) Дан текст, указываем конкретный символ oldValue (старое значение), конкретный символ на который будем менять newValue будем менять старый символ на новый и возвращать строку.
{
    string result = string.Empty;                         // чтобы себя не путать заводим новую строку, говорим, что она пустая и ложим туда результат.

    int length = text.Length;                             // пишем код, чтобы узнать длину текста пишем так.
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";   // если текст с символом i совпал с oldValue, то в результат ложим новое значение newValue.
        else result = result + $"{text[i]}";                        // если же нет, то в текущий результат добавить символ, который и был.
    }
    return result;                                        // чтобы не забыть, будем возвращать результат.
}

string newText = Replace(text, ' ', '|'); // запустим нашу программу, newText присвоим Replace (заменить) и указываем, что на что.

// Console.WriteLine(newText);
// Console.WriteLine();          // выведем на консоль пустую строку, разделим, чтобы было красиво.

// newText = Replace(text, 'к', 'К'); // string не надо, так как был уже ... наверно...))

// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(text, 'с', 'С');
// Console.WriteLine(newText);

/*
---- ФУНКЦИИ В ПРОГРАММИРОВАНИИ ------
=== Работа с массивами. Задача упорядочить данные в массиве. Пример массив 6 8 3 2 1 4 5 7 Решим через min.
Начнем с первого значения в массиве, найдем минимальное значение в массиве и поменяем местами (заменим) с первым.
Дальше следующий шаг, зафиксиремся на втором значении, первое нам уже не нужно...
Так будем делать дальше......
---- выразимся короче и по главному----:
 1. Найти позицию минимального элемента
 в неотсортированной части массива
 2. Произвести обмен этого значения со
 значением первой неотсортированной позиции
 3. Повторять пока есть не отсортированные
 элементы
*/
// Давайте писать код:

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };           //заведём масив, в котором будем отсортировывать
// напишем для решения несколько методов:

// Метод 1 void:
void PrintArray(int[] array) // печатать массив array, в качестве аргумента будет приходить массив.
{
    int count = array.Length; // получение количества элементов, присваиваем длину массива.

    for (int i = 0; i < count; i++)
    {
        //Console.Write($"{array[i]} "); // можно вывести на консоле в одной строчке
    }
    //Console.WriteLine();
}
//PrintArray(arr);

// Метод 2. Метод, который будет упорядочивать наш массив.
void SelectionSort(int[] array)   // SelectionSort (сортировка выбора), в качестве аргументов будет приходит массив.
{
    for (int i = 0; i < array.Length - 1; i++)   // тут не будем делать вот так int count = array.Length;, сделаем
                                                 // i < array.Length - 1; !!! особенность (-1).
    {
        int minPosition = i;     // запоминаем минимальную позицию, с которой в дальнейшем будем проводить какие-то действия.
        
        for (int j = i + 1; j < array.Length; j++)        // начинаем c i+1, так как выше уже нашли и проверили.
        {
            if (array[j] < array[minPosition]) minPosition = j;   // ищем мах // если текущий элемент масива [j] меньше, который мы предполагали мин, то эту позицию сохраняем в мин.
        }
        int temporary = array[i];      // переменная temporary (временный), нужно поменять позицию minPosition с той позицией, которую нашли - выше). 
        array[i] = array[minPosition]; // простой обмен переменных местами // мы положим в массив со значением i = c minPosition
        array[minPosition] = temporary; // в мин кладём временный.
    }
}
//PrintArray(arr);
//SelectionSort(arr);   // вызываем упорядочивания массива

//PrintArray(arr);

/*
---ИТОГИ---
Циклов много не бывает
Бывают циклы в циклах
● ничего не принимают, ничего не возвращают
● что-то принимают, ничего не возвращают
● ничего не принимают, что-то возвращают
● что-то принимают, что-то возвращают
Может есть и другие? Точно есть.
Сколько?
--- Сделай сам:
Задачи
Максимум в массиве
Минимум в массиве
Максимум в упорядоченном массиве
Подсчет цифр числа
*/