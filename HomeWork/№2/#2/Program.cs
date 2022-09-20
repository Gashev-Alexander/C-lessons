Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = Convert.ToString(number);

if (numberText.Length > 2)

{
int second = (number % 10);
    Console.WriteLine($"Третья цифра-> {second}");
}

else 
{
Console.WriteLine("Третьей цифры нет.");
}