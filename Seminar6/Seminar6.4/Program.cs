// y = k1 * x + b1, y = k2 * x + b2

Console.Clear();
Console.WriteLine("Введите число b1:");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1:");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2:");
int k2 = Convert.ToInt32(Console.ReadLine());

int x = (b2 - b1)/(k1 - k2);
int crossPoint1 = k1 * x + b1;
int crossPoint2 = k2 * x + b2;


Console.WriteLine($"{crossPoint1}, {crossPoint2}");