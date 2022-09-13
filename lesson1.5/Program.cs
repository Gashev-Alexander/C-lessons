Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine ();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША");
}
if(username.ToLower() == "саша")
{
    Console.WriteLine("Ура, это же Санек");
}
else
{
    Console.Write("Привет, "); 
    Console.WriteLine(username);
}