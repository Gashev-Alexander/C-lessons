static void Main(string[] args)
{
    Console.Write($"\nВведите размер массива:\t");
    int elementsCount = int.Parse(Console.ReadLine());
    int[] myArray = new int[elementsCount];
    for (int i = 0; i < myArray.Length; i++)
    {
        Console.Write($"\nВведите массив с индексом {i}:\t");
        myArray[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("\nВывод массива:");

    for (int i = 0; i < myArray.Length; i++)
    {
        Console.WriteLine(myArray[i]);
    }

    Console.ReadLine();
}