int Exponentiation(int A, int B)
{
  int result = 1;
  for(int i=1; i <= B; i++)
  {
    result = result * A;
  }
    return result;
}

Console.Write("Enter A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int B = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(A, B);
Console.WriteLine($"{A},{B} => {exponentiation}");