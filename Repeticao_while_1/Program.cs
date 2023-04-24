Console.WriteLine("## Instrução While ##");

Console.WriteLine("## TABUADA ##\n");
int num, i = 0;
Console.WriteLine("Qual número você quer saber a tabuada?");
num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{

    Console.WriteLine($"Tabuada de {num}\n");

    while (i <= 10)
    {
        Console.WriteLine($"{num} x {i} = {num*i}");
        i++;

    }
} else
{
    Console.WriteLine("\nO número deve ser maior que zero!");
}

Console.ReadKey();