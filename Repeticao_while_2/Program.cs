Console.WriteLine("## Instrução While 02 - break ##\n");

int num;
string p = "";

Console.WriteLine("Número Par\n");
while (p != "n")
{


Console.WriteLine("Informe um número:");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine($"{num} é par!");
} else
{
    Console.WriteLine($"{num} é impar!");
}

    Console.WriteLine("Quer informar outro número? (S/N)");
p = Console.ReadLine().ToLower();

if (p == "n")
    break;
}

Console.WriteLine("\nCoordenadas (x,y)\n");

int x = 0;
while (x < 5)
{

    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y}) ");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();