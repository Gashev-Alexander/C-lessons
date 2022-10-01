double[,] kof = new double[2, 2];
double[] crossPoint = new double[2];

void InputKoff(){
  for (int i = 0; i < kof.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го");
    for (int j = 0; j < kof.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      kof[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] kof)
{
  crossPoint[0] = (kof[1,1] - kof[0,1]) / (kof[0,0] - kof[1,0]);
  crossPoint[1] = crossPoint[0] * kof[0,0] + kof[0,1];
  return crossPoint;
}

void OutputResponse(double[,] kof)
{
  if (kof[0,0] == kof[1,0] && kof[0,1] == kof[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (kof[0,0] == kof[1,0] && kof[0,1] != kof[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(kof);
    Console.Write($"\nПрямые пересекаются в точке => ({crossPoint[0]}, {crossPoint[1]})");
  }
}

InputKoff();
OutputResponse(kof);