Console.Clear();
double[,] coor = new double[2, 2];
double[] cross = new double[2];

void Coordinates()
{
    for (int i = 0; i < coor.GetLength(0); i++)
    {
        for (int j = 0; j < coor.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"Введите значение b{i + 1}: ");
            }
            else
            {
                Console.Write($"Введите значение k{i + 1}: ");
            }
            coor[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] answer(double[,] coor)
{
    cross[0] = (coor[0, 0] - coor[1, 0]) / (coor[1, 1] - coor[0, 1]);
    cross[1] = cross[0] * coor[0, 1] + coor[0, 0];
    return cross;
}

void OutputResponse(double[,] coor)
{
    if ((coor[0, 0] == coor[1, 0] && coor[0, 1] == coor[1, 1])
    || (coor[0, 0] == coor[1, 0] && coor[0, 1] != coor[1, 1]))
    {
        Console.WriteLine("\nПрямые не пересекаются.");
    }
    else
    {
        answer(coor);
        Console.Write($"\nПрямые пересекаются в точке => ({cross[0]}, {cross[1]})");
    }
}

Coordinates();
OutputResponse(coor);