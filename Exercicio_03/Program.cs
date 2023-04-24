Console.WriteLine("## Exercício 03 ##");

Console.WriteLine("Loop For:");

int i, soma = 0;

for (i = 1; i <= 10; i++)
{
    if (i == 10)
        Console.WriteLine($"{i}.");
    else
        Console.Write($"{i}, ");
    soma += i;
}
Console.WriteLine($"\nSoma: {soma}\n");


Console.WriteLine("Loop While:");
i = 1;
soma = 0;

while (i <= 10)
{
    if (i == 10)
        Console.WriteLine($"{i}.");
    else
        Console.Write($"{i}, ");
    soma += i;
    i++;
}
Console.WriteLine($"\nSoma: {soma}\n");

Console.WriteLine("Loop Do-While:");
i = 1;
soma = 0;

do
{
    if (i == 10)
        Console.WriteLine($"{i}.");
    else
        Console.Write($"{i}, ");
    soma += i;
    i++;

} while (i <= 10);
Console.WriteLine($"\nSoma: {soma}\n");


Console.ReadKey();