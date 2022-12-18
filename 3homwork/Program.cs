string line = Console.ReadLine();
if (line.Length == 5)
{
    if (line[0] == line[4] && line[1] == line[3])
    {
        Console.WriteLine($"{line}->да");
    }
    else
    {
        Console.WriteLine($"{line}->нет");
    }
}
else
{
    Console.WriteLine("число не пятизначное");
}

