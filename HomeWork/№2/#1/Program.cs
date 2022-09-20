Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
int second = (number / 10) % 10 ;

Console.Write($"Второе число: {second}");


// Второй способ
// Console.WriteLine("Введите трехзначное число: ");
//     {
//         string input = Console.ReadLine();
//             Console.WriteLine("{0}->{1}",input, input[1]);
//     }