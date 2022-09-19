Console.Clear();
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
if (a == b * b)
{
    Console.Write($"Число {a} является квадратом числа {b}");
}
else
{
    Console.Write("Корень ты здесь не найдешь");
}