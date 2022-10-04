Console.Clear();
Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if ((a + b) > c&&(c + b) > a&&(a + c) > b)
{
    Console.WriteLine("\nТриугольник жи есть- вот это он!");
}
else
{
    Console.WriteLine("\nЭто так не работает!");
}