Console.Clear();
int number = int.Parse(Console.ReadLine());

string res1 = Convert.ToString(number, 2);
string res2 = DecToNum(number, 5);

Console.WriteLine($"{number}->{res1}");
Console.WriteLine($"{number}->{res2}");

string DecToNum(int decNumber, int otherSystem)
{
    string res = "";
    string nums = "0123456789ABCDEF";
    while (decNumber > 0)
    {
        int ost = decNumber / otherSystem;
        res = nums[decNumber - otherSystem * ost] + res;
        decNumber /= otherSystem;
    }
    return res;
}
