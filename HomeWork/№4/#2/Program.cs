Console.Clear();
Console.Write("Enter N: ");
int N = Convert.ToInt32(Console.ReadLine());
    int SumNum(int N)
{    
    int counter = Convert.ToString(N).Length;
    int advance = 0;
    int result = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = N - N % 10;
        result = result + (N - advance);
        N = N / 10;
    }
    return result;
}

int sumNum = SumNum(N);
Console.WriteLine($"{N} => {sumNum}");