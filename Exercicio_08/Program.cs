Console.WriteLine("## Exercício 08 ##\n");

int num, fatorial;

Console.Write("Digite um número para o cálculo fatorial: ");
num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nFatorial de {num}");

Console.Write($"{num}! = ");
fatorial = num;
for (int i = num; i >= 1; i--)
{

    if (i == 1)
    {
        Console.Write($"{i} = {fatorial}");
    } else
    {
        fatorial = fatorial * (i - 1);
        Console.Write($"{i}*");
    }
}

Console.WriteLine("\n\nFim do processamento...");

Console.ReadKey();