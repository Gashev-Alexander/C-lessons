Console.Clear();
Console.Write("a = ");
int a = int.Parse(Console.ReadLine());
Console.Write("b = ");
int b = int.Parse(Console.ReadLine());
if (a * a == b) {
    Console.Write("Yes");
} else {
    Console.Write("No");
}