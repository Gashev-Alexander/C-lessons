Console.Write("Введите пятизначное число: ");
string X = Console.ReadLine();

void CheckingX(string X){
  if (X[0]==X[4] || X[1]==X[3]){
    Console.WriteLine($"{X} -> YES!");
  }
  else Console.WriteLine($"{X} -> NO!");
}

if (X.Length == 5){
  CheckingX(X);
}
else Console.WriteLine($"Error! Alarm! Warning! Alarm! Error!");