Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
for(int i=1 ; i<=num; i++)
{
    Console.Write($" {(i*i)*i} ");
}