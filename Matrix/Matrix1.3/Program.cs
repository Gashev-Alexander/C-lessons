static void Print(int[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++, Console.WriteLine())
for (int j = 0; j < arr.GetLength(1); j++)
Console.Write("{0,3}", arr[i, j]);
}
static void Main(string[] args)
{
Console.Write("Введите размер массива:\nn=");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("m=");
int m = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[n, m];
Random rnd = new Random();
for (int i = 0; i < arr.GetLength(0); i++)
for (int j = 0; j < arr.GetLength(1); j++)
arr[i, j] = rnd.Next(1, 10);
Console.WriteLine("Исходный массив:");
Print(arr);
            
// перемещение элементов массива
int tmp;
tmp = arr[arr.GetLength(0) - 1, 0];
arr[arr.GetLength(0) - 1, 0] = arr[0, arr.GetLength(1) - 1];
arr[0, arr.GetLength(1) - 1] = tmp;
Console.WriteLine("Измененный массив:");
Print(arr);
Console.ReadKey();
}