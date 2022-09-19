Console.Clear();
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
if ((a % 7 == 0) && (a % 23 == 0))
{
    Console.Write("Yes");
}else{
    Console.WriteLine("NO");
}