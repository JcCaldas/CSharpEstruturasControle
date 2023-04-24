Console.WriteLine("## Exercício 06 ##\n");

Console.WriteLine("Números pares entre 10 e 20 (exceto 16).\n");

Console.WriteLine("Loop For de 2 em 2:");
for (int i = 10; i <= 20; i+=2)
{
    if (i == 16)
        continue;
    else
        Console.WriteLine(i);
}

Console.WriteLine("\nLoop For de 1 em 1:");
for (int i = 10; i <= 20; i++)
{
    if (i == 16)
    {
        continue;
    } 
    
    else
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }
    }
}

Console.WriteLine("\nLoop Infinito:");

int cont = 10;

while (true)
{
    if (cont % 2 == 0)
    {
        if (cont == 16)
        {
            cont++;
            continue;
        } else if (cont % 2 == 0)
        {
            Console.WriteLine(cont);
        }
    }

    if (cont == 20)
        break;

    cont++;
}

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();