{
        Console.WriteLine("Введите два числа: ");
        int a, b;
        Console.WriteLine("Введите первое число: ");
        int a = Convert.ToInt32(Console.Read());
        Console.WriteLine("Введите второе число: ");
        int b = Convert.ToInt32(Console.Read());

        if (a > b)
            {
                Console.WriteLine($" {a} больше чем {b} ");
            }
        else if (b > a)
            {
                Console.WriteLine($" {b} больше чем {a} ");
            }
}