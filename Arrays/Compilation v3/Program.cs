Console.Clear();
Console.Write($"Выберите тип заполнения массива (Ручной/Автоматический)");
Console.Write($"\nSelect the type of array filling (Manual/Automatic)\nОтвет/Answer:");
switch(Console.ReadLine())
{
    case "Ручной":
    case "ручной":
    case "Manual":
    case "manual":
    case "рука":
    case "Рука":
    case "Hand":
    case "hand":
        Console.Clear();
        Console.Write("Введите размер массива\nEnter the size of the array: ");
        int SizeMas = int.Parse(Console.ReadLine());
        int[] array = new int[SizeMas];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Введите элемент массива с индексом {i}\n      Enter array element at index {i} : ");
            array[i] = int.Parse(Console.ReadLine());
        }
            Console.WriteLine("\nВывод массива\nArray Output:");
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
    case "automatic":
    case "Automatic":
        Console.Clear();
        Console.Write("Введите размер массива\nEnter the size of the array: ");  
        int SizeMas1 = int.Parse(Console.ReadLine());
        int[] array1 = GetBinaryArray(SizeMas1);
        Console.WriteLine($"[{String.Join(",", array1)}]");
        int[] GetBinaryArray(int size)
        {
            Console.Write("Введите возможное максимальное значение элемента массива \n   Enter the possible maximum value of the array element: ");
            int razmer = int.Parse(Console.ReadLine());
            int[] result = new int [size];
            for (int i = 0; i < size; i++)
            result[i] = new Random().Next(razmer);
        return result;
        }
    break;    

    case "Ногой":
    case "ногой":
    case "Нога":
    case "нога":
    case "Leg":
    case "leg":
        Console.WriteLine("Я смотрю ты Гимнаст=)\nI see you are a gymnast =)");
    break;

    default:
        Console.WriteLine("Ошибка ввода, попробуй еще раз!\nInput error, please try again!");
    break;


// Надо присвоить переменной myArray два значения (array = array1) 
// array массив вводимый пользователем, array1 автоматический заолняемый массив

// int[] nums = myArray;
 
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

// //Сортировка массива
// Console.WriteLine("\n\nВывод отсортированного массива:");
// {
//     void SortArray(int[] up)
//     {
//         int count = up.Length;
//         int i = 0;
//         Console.Write("[");
//         while(i < count)
//     {
//         Console.Write(up[i]);
//         i++;
//         if (i < count)
//     {
//         Console.Write(", ");
//     }
//     }
//         Console.Write("]");
//     }
// SortArray(nums);

// }

}