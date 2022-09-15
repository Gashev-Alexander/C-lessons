
        {
            Console.WriteLine("Введи 2 числа и мы тебе скажем какое из них больше");
            int a, b;
            Console.WriteLine("Введи свое первое число - ");
            a = Convert.ToInt32(Console.Read());
            Console.WriteLine("Введи свое второе число - ");
            b = Convert.ToInt32(Console.Read());
 
            bool ver1 = a > b;
 
            if (ver1)
            {
                Console.WriteLine($"Число {a} больше чем {b}");
            }
                else
                {
                    Console.WriteLine($"Число {b} больше чем {a}");
                }
        }   