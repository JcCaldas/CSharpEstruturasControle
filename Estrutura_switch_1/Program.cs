Console.WriteLine("## Estrutura Switch-case ##\n");

Console.WriteLine("Valor da Compra R$600,00\n");
Console.WriteLine("Informe o nº de parcelas (1 a 3)\t");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R$ {600 / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPrestação R$ {600 / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R$ {600 / numeroParcelas}");
        break;
    //default é opcional.
    default:
        Console.WriteLine("\nPrestações inválidas!");
        break;

}
Console.WriteLine("\nFim do processamento prestações...");

Console.WriteLine("\nInforme um número inteiro: \t");
int num = Convert.ToInt32(Console.ReadLine());

switch (num % 2)
{
    case 0:
        Console.WriteLine($"\n{num} é par");
        break;
    case 1:
        Console.WriteLine($"\n{num} é impar");
        break;
}

Console.WriteLine("Fim do processamento par ou impar...");



Console.ReadKey();