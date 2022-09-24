Console.Clear();
Console.Write("Введите номер четверти : ");
int X = int.Parse(Console.ReadLine());

switch (X)
{
case 1:
Console.WriteLine("X>0&&Y>0");
break;
case 2:
Console.WriteLine("X<0&&Y>0");
break;
case 3:
Console.WriteLine("X<0&&Y<0");
break;
case 4:
Console.WriteLine("X>0&&Y<0");
break;
default:
Console.WriteLine("Вы ввели не подходящее число");
break;
}