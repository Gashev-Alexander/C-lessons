Console.Clear();
Console.Write($"Выберите тип заполнения массива (Ручной/Автоматический)\nОтвет: ");
switch(Console.ReadLine())
{
    case "Ручной":
    case "ручной":
    case "рука":
    case "Рука":
    case "Hand":
    case "hand":
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int SizeMas = int.Parse(Console.ReadLine());
        int[] array = new int[SizeMas];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент массива с индексом {i} : ");
            array[i] = int.Parse(Console.ReadLine());
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
    break;
    
    case "Автоматический":
    case "автоматический":
    case "Авто":
    case "авто":
    case "auto":
    case "Auto":
        Console.Clear();
        Console.Write("Введите размер массива: ");
        int SizeMas1 = int.Parse(Console.ReadLine());
        int[] array1 = GetBinaryArray(SizeMas1);
        Console.WriteLine($"[{String.Join(",", array1)}]");
        
        int[] GetBinaryArray(int size)
        {
            int[] result = new int  [size];
            for (int i = 0; i < size; i++)
            {
                result[i] = new Random().Next(9999);
            }
        return result;
        }
    break;    

    case "Нога":
    case "нога":
    case "Leg":
    case "leg":
        Console.WriteLine("Я смотрю ты Гимнаст=)");
    break;

    default:
        Console.WriteLine("Ошибка ввода, попробуй еще раз!");
    break;
}