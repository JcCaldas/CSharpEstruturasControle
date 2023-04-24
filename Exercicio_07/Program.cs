Console.WriteLine("## Exercício 07 ##\n");

Console.WriteLine("Triângulo de ângulo reto\n");

for (int i = 0; i <= 4; i++)
{
    Console.WriteLine("");
    for (int j = i+1; j > 0; j--)
    {
        Console.Write("*");
    }
}

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();