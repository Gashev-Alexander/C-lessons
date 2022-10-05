// Двумерный массив на примере парковки
bool[,] Parking = new bool[5, 5];
Parking[1, 1] = true;
Parking[2, 2] = true;
Parking[3, 3] = true;
Parking[3, 1] = true;
Parking[1, 3] = true;
for (int row = 0; row < Parking.GetLength(0); row++)
{
    for (int coll = 0; coll < Parking.GetLength(1); coll++)
    {
        Console.Write(Parking[row, coll] ? "X" : "+");
    }
    Console.WriteLine();
}
