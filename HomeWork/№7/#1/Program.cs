Console.Clear();
Console.Write("Введите число строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число колон: ");
int y = Convert.ToInt32(Console.ReadLine());

double[,] Meow = new double[x, y];

Random array = new Random();
for (int i = 0; i < Meow.GetLength(0); i++)
{
    for (int j = 0; j < Meow.GetLength(0); j++)
    {
        Meow[i, j] = array.NextDouble() * 10;
        Console.Write("{0,6:F1}", Meow[i, j]);
    }
    Console.WriteLine();
}