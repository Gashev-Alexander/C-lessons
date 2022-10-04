static void Main(string[] args)
{
    WriteColorLine("Hello World", ConsoleColor.Red);
    string input = Console.ReadLine() + "!";
    Console.WriteLine(input);
    Console.WriteLine("Hello" + "World!");
    WriteColorLine("Buy!", ConsoleColor.Blue);
}

static void WriteColorLine(string message, ConsoleColor color)
{
    ConsoleColor oldColor = Console.ForegroundColor;

    Console.ForegroundColor = color;
    Console.WriteLine(message);

    Console.ForegroundColor = oldColor;
}