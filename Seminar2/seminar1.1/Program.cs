Console.Clear();
int num = new Random().Next(100, 999);

int first_digit = num / 100;
int second_digit = num % 10;

Console.WriteLine(num);
Console.WriteLine($"{first_digit}{second_digit}");
