
/* Задача: Инициализируйте двумерный массив* с именем arr2d заданными целочисленными значениями: 
   ((1, 2); (3, 4); (5, 6)). 
   1) Сначала выведите все элементы массива.
   2) После этого выведите следующие элементы в консоль (элементы для вывода отмечены синим цветом): => 3, 5 */
/*
int[,] arr2d = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

void PrintArray2D(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}
Console.WriteLine();

void PrintArray2DElements(int[,] arr)
{
    Console.WriteLine($"element1 = {arr[1, 0]} и element2 = {arr[2, 0]} ");
}

// PrintArray2D(arr2d);
// PrintArray2DElements(arr2d);
// Console.WriteLine();

bool IsEven(int value)
{
 return value % 2 == 0;
}


bool d = IsEven(5);
Console.WriteLine(d);

*/

// Сделайте случайные слова.
void btnGo_Click(object sender, EventArgs e)
{
    lstWords.Items.Clear();

    // Получаем количество слов и букв за слово.
    int num_letters = int.Parse(txtNumLetters.Text);
    int num_words = int.Parse(txtNumWords.Text);

    // Создаем массив букв, которые мы будем использовать.
    char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

    // Создаем генератор случайных чисел.
    Random rand = new Random();

    // Делаем слова.
    for (int i = 1; i <= num_words; i++)
    {
        // Сделайте слово.
        string word = "";
        for (int j = 1; j <= num_letters; j++)
        {
            // Выбор случайного числа от 0 до 25
            // для выбора буквы из массива букв.
            int letter_num = rand.Next(0, letters.Length - 1);

            // Добавить письмо.
            word += letters[letter_num];
        }

        // Добавьте слово в список.
        lstWords.Items.Add(word);
    }
}

