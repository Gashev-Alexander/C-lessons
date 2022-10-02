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

// void FillArray(int[,,] matr)
// {
// for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         for (int k = 0; k < matr.GetLength(2); k++)
//         {
//         matr[i, j, k] = new Random().Next(1,27);
//         }
//     }
//     Console.WriteLine();
// }
// }

int[,,] matrix = new int [3, 3, 3];
// PrintArray(matrix);
// FillArray(matrix);
 PrintArray(matrix);


int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows; 


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        for (int k = 0; k < rows; k++)
        {
            Console.Write($"{matrix[i, j, k]} \t");
        }
    }
    Console.WriteLine();
}