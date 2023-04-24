using System.Security.Cryptography.X509Certificates;

Console.WriteLine("## Instrução for ##\n");

for (int i = 0, j = 0 ; i+j < 10; i++, j++)
{
    Console.WriteLine($"i = {i} e j = {j}");
}

Console.WriteLine("\nCoordenadas (x,y)");

for (int x = 0; x < 5; x++)
{
    for (int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y}) ");
    }
    Console.WriteLine();
}

Console.ReadKey();