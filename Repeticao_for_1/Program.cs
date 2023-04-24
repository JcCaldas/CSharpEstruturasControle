Console.WriteLine("## Instrução for ##\n");

Console.WriteLine("###\tTabuada\t###\n");

Console.Write("Digite um número para fazer a tabuada: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\nTabuada de {num}\n");

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}

Console.WriteLine("Fim do processamento...");

Console.ReadKey();