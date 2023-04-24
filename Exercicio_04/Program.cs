Console.WriteLine("## Exercício 02 ##\n");

int num, resultado;
string resp;

while (true)
{

    Console.Write("Digite um número: ");
    num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Tábuada de {num}");
    for (int i = 0; i <= 10; i++)
    {

        resultado = num * i;
        Console.WriteLine($"{num} x {i} = {resultado}");

    }

    Console.WriteLine("Deseja outra tabuada? (S/N)");
    resp = Console.ReadLine().ToUpper();

    if (resp == "N")
        break;

}

Console.WriteLine("Fim do processamento...");


Console.ReadKey();