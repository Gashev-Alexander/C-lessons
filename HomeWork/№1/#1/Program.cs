{
            Console.WriteLine("Введите первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
 
            if(a > b)
            {
                Console.WriteLine($"Max = {a}");
            }
            else if (a < b)
            {
                Console.WriteLine($"Max = {b}");
            }
            else
            {
                Console.WriteLine("Оба числа равны");
            }
            Console.ReadKey();
        }