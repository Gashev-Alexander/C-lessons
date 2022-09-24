Console.Clear();
Console.Write("Введите Х: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if(X>0&&Y>0)
{
    Console.WriteLine("1");
}

if(X<0&&Y>0)
{
    Console.WriteLine("2");
}

if(X<0&&Y<0)
{
    Console.WriteLine("3");
}

if(X>0&&Y<0)
{
    Console.WriteLine("4");
}