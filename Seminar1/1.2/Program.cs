Console.Clear();
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
if (a % b == 0) 
{
    Console.Write("Yes");
} 
else 
{
    Console.WriteLine($"NO-> Остаток {a % b}");
}