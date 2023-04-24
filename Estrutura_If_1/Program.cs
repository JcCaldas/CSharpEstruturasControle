Console.WriteLine("## Instrução if ##\n");

Console.WriteLine("Cliente Especial (S/N)");
var resposta = Console.ReadLine().ToUpper();

if (resposta == "S")
{
    Console.WriteLine("Desconto de 10%");
}

Console.WriteLine("Fim do processamento de cliente\n");

Console.WriteLine("Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y\t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
    Console.WriteLine("x > y");

if (x < y)
    Console.WriteLine("x < y");

if (x == y) 
    Console.WriteLine("x = y");

Console.WriteLine("Fim de x e y");


Console.ReadKey();