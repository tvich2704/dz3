int n = int.Parse(Console.ReadLine());
Console.Write($"{n}->");
if (n < 0)
{
    n = n * (-1);
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"-{Math.Pow(i, 3)} ");
    }
}
else
{
    for (int i = 1; i <= n; i++)
    {
        Console.Write($"{Math.Pow(i, 3)} ");
    }
}

