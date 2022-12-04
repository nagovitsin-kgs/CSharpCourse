

Console.Write("Write number 2: ");
int N = int.Parse(Console.ReadLine());
for (int i = 1; i <= N; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
Console.ReadKey();

