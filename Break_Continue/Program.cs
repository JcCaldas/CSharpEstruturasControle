Console.WriteLine("## Break e Continue ##\n");

for (; ; )
{
    Console.Write("Tecle algo (X sai): ");
    var opcao = Console.ReadLine();

    Console.WriteLine(opcao.ToUpper());

    if (opcao == "X" || opcao == "x")
    {
        Console.WriteLine("Tchau...");
        break;
    }
}

for (int i = 0; i <= 10; i++)
{
    if (i == 4)
        continue;

    Console.WriteLine(i);
}

int n = 1;
while (n <= 10)
{
    if (n == 5)
    {
        n += 1;
        continue;
    }

    Console.WriteLine($"n = {n}");
    n++;
}

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
        continue;

    if (i > 8)
        break;

    Console.WriteLine($"{i}");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();