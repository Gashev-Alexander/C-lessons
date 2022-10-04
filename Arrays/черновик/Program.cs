// программа создания массивов через ручной ввод и через рандом.
// программа построена на функции if
// не могу понять как осортировать выведеный массив потому что не могу вытянуть его из if else
Console.Clear();
Console.Write($"Введите метод заполнения массива \nОтвет: ");
string? version = Console.ReadLine();
    if(version == "Ручной" || version == "ручной" || version == "hand" || version == "Hand"
     || version == "Рука" || version == "рука" || version == "manual" || version == "Manual")
    {
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int SizeMas = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[SizeMas];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент массива с индексом {i} : ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
            Console.WriteLine("\nВывод массива:");
            void TopArray(int[] coll)
        {
            int count = coll.Length;
            int i = 0;
            Console.Write("[");
            while(i < count)
        {
            Console.Write(coll[i]);
            i++;
            if (i < count)

            {
                Console.Write(", ");
            }
        }   
        Console.Write("]");
        }
    TopArray(array);
    }
    
    else if(version == "auto" || version == "automatic" || version == "авто" || version == "автоматический")
    {
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int SizeMas1 = Convert.ToInt32(Console.ReadLine());
        int[] array1 = GetBinaryArray(SizeMas1);
        Console.WriteLine($"[{String.Join(",", array1)}]");
        
        int[] GetBinaryArray(int size)
        {
        Console.Clear();
        Console.Write("Введите максимально-возможное значение элемента массива: ");
            int Melem = Convert.ToInt32(Console.ReadLine());
            int[] result = new int  [size];
            for (int i = 0; i < size; i++)
            {
                result[i] = new Random().Next(Melem);
            }
        return result;
        }
    }
    else
    {
        Console.WriteLine("Ошибка ввода, попробуй еще раз!");
    }

// Console.WriteLine();
// int[] nums = new int[version];
// Console.WriteLine($"{nums}");
// // сортировка
// int temp;
// for (int i = 0; i < nums.Length - 1; i++)
// {
//     for (int j = i + 1; j < nums.Length; j++)
//     {
//         if (nums[i] > nums[j])
//         {
//             temp = nums[i];
//             nums[i] = nums[j];
//             nums[j] = temp;
//         }
//     }
// }
 
// // вывод
// Console.WriteLine("\nВывод отсортированного массива");
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.WriteLine(nums[i]);
// }
