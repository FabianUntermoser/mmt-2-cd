using Add;

if (args.Length != 2)
{
    System.Console.Error.WriteLine("Usage: add <number1> <number2>");
    return;
}

int number1, number2;

if (!int.TryParse(args[0], out number1))
{
    System.Console.Error.WriteLine($"{args[0]} is not an integer");
    return;
}

if (!int.TryParse(args[1], out number2))
{
    System.Console.Error.WriteLine($"{args[1]} is not an integer");
    return;
}

System.Console.WriteLine($"{NumberCruncher.AddNumbers(number1, number2)}");