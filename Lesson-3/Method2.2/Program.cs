void method2(string msg)
{
    Console.WriteLine(msg);
}
method2("Текст сообщения");

void method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
method21("Текст сообщения", 4);