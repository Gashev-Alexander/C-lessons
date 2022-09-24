Console.Clear();
Console.Write("Введите номер четверти: ");
int X = int.Parse(Console.ReadLine());


if(X == 1)
{
    Console.WriteLine("X>0 и Y>0");
}

if(X == 2)
{
    Console.WriteLine("X<0 и Y>0");
}

if(X == 3)
{
    Console.WriteLine("X<0 и Y<0");
}

if(X == 4)
{
    Console.WriteLine("X>0 и Y<0");
}