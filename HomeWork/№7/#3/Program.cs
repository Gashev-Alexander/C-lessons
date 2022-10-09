Console.Clear();
Console.Write("Введите число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[x, y];
Random Meow = new Random();
int[] summ = new int[y];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = Meow.Next(0, 10);

    }
}
Console.WriteLine();
for (int i = 0; i < x; i++)
{
    for (int j = 0; j < y; j++)
    {

        Console.Write(matrix[i, j] + "\t");
        summ[i] += matrix[j, i];
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.Write("Среднее арифметическое число каждого стобца:\n");
foreach (double nums in summ)
{
    Console.Write($"{(nums / y):F1}\t");
}