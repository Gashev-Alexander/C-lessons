// массив обыкновенный
// int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };

// Двумерный массив
// int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };

// Вывод двумерного массива
// int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }};
// foreach (int i in numbers)
//     Console.Write($"{i} ");

// Разделение всех элементов двумерного массива
// int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }};
// int rows = numbers.GetUpperBound(0) + 1;    // количество строк
// int columns = numbers.Length / rows;        // количество столбцов
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         Console.Write($"{numbers[i, j]} \t");
//     }
//     Console.WriteLine();
// }

// Зубчатый массив
int[][] numbers = new int[3][];
numbers[0] = new int[] { 1, 2 };
numbers[1] = new int[] { 1, 2, 3 };
numbers[2] = new int[] { 1, 2, 3, 4, 5 };

// 
foreach (int[] row in numbers)
{
    foreach (int number in row)
    {
        Console.Write($"{number} \t");
    }
    Console.WriteLine();
}

// // перебор с помощью цикла for
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = 0; j < numbers[i].Length; j++)
    {
        Console.Write($"{numbers[i][j]} \t");
    }
    Console.WriteLine();
}