﻿/* --- Массивы (Руководство по программированию на C#):--- */
// --- 1). Обзор:---
/*В структуре данных массива можно хранить несколько переменных одного типа. Чтобы объявить массив, 
  следует указать тип его элементов. Если требуется, чтобы массив мог хранить элементы любого типа, 
  можно указать object в качестве его типа. В унифицированной системе типов C# все типы, стандартные 
  и определяемые пользователем, ссылочные типы и типы значений напрямую или косвенно наследуются из Object.*/
  
public class Arrays
{
type[] arrayName; // type (ТИП), а arrayName (ИМЯ МАССИВА). 

// --- Пример:---
/*В следующих примерах создаются одномерные массивы, многомерные массивы и массивы массивов:*/

class TestArraysClass // класс тестовых массивов.
{
    static void Main()
    {
        // Объявите одномерный массив из 5 целых чисел.
        int[] array1 = new int[5];

        // Объявляйте и устанавливайте значения элементов массива.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Альтернативный синтаксис.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // Объявите двумерный массив.
        int[,] multiDimensionalArray1 = new int[2, 3]; // multiDimensionalArray (многомерный массив)

        // Объявляйте и устанавливайте значения элементов массива.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Объявите неровный массив.
        int[][] jaggedArray = new int[6][];

        // Установите значения первого массива в структуре неровного массива.
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };
    }
}
/* --- Общие сведения о массивах ---
   
   Массив имеет следующие свойства:
 - Массив может быть одномерным, многомерным или массивом массивов.
 - Количество измерений и длина каждого из измерений задаются, когда создается экземпляр массива. 
   Эти значения нельзя изменить во время существования экземпляра.
 - Используемые по умолчанию значения числовых элементов массива равны нулю, и элементам ссылки 
   присвоено значение null.
 - В массиве массивов элементы являются ссылочными типами и инициализируются значением null.
 - Массивы индексируются от нуля: массив с n элементами индексируется от 0 до n-1.
 - Элементы массива могут иметь любой тип, в том числе тип массива.
 - Типы массивов — это ссылочные типы, производные от абстрактного базового типа . 
   Все массивы реализуют IList и IEnumerable. Для итерации по массиву можно использовать оператор foreach. 
   Одномерные массивы также реализуют IList<T> и IEnumerable<T>.*/

/* --- Поведение значения по умолчанию ---
 - Для типов значений элементы массива инициализируются со значением по умолчанию — шаблоном с нулевыми битами; 
   элементы будут иметь значение.
 - Все ссылочные типы (в том числе не допускающие значения NULL) имеют значения.
 - Для типов, допускающих значения NULL, параметр HasValue имеет значение false, а для элементов будет 
   установлено значение null.*/

/* --- Массивы как объекты ---
   В C# массивы представляют собой реальные объекты, а не просто адресуемые области непрерывной памяти, как в C и C++. 
   Array — это абстрактный базовый тип для всех типов массивов. Вы можете использовать свойства и другие 
   члены класса, входящие в Array. Например, с помощью свойства Length можно получить длину массива. 
   В следующем коде значение длины массива numbers (5) присваивается переменной с именем lengthOfNumbers:*/
int[] numbers = { 1, 2, 3, 4, 5 };
int lengthOfNumbers = numbers.Length;
/*В классе Array представлено множество других полезных методов и свойств для сортировки, поиска и копирования 
  массивов. В следующем примере свойство Rank используется для отображения количества измерений массива. */
class TestArraysClass
{
    static void Main()
    {
        // Объявляйте и инициализируйте массив.
        int[,] theArray = new int[5, 10];
        System.Console.WriteLine("Массив имеет {0} измерения.", theArray.Rank);
    }
}
// Вывод: Массив имеет 2 измерения.




}


