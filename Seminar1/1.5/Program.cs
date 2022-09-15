Console.Write("Write N = ");
int n = Math.Abs(int.Parse(Console.ReadLine()));
for (int i = -n; i <= n; i++)
{
    Console.Write($"{i} ");
}