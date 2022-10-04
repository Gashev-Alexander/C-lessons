Console.Clear();
Console.Write ("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine ());

int[] FArray = new int[N];
FArray[0] = 0;
FArray[1] = 1;
Console.Write($"{FArray[0]} {FArray[1]} ");
for (int i = 2; i < N; i++){
FArray[i] = FArray[i-1] + FArray[i-2];
Console.Write($"{FArray[i]} ");
}