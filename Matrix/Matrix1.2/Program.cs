void PrintArray(int[,,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int k = 0; k < matr.GetLength(2); k++)
        {
            Console.Write($"{matr[i, j, k]} ");
        }
    }
    Console.WriteLine();
}
}

void FillArray(int[,,] matr)
{
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        for (int k = 0; k < matr.GetLength(2); k++)
        {
        matr[i, j, k] = new Random().Next(1,27);
        }
    }
    Console.WriteLine();
}
}

int[,,] matrix = new int [3, 3, 3];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);