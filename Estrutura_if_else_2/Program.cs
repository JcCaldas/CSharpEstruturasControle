﻿Console.WriteLine("## Instrução if-else ##\n");

Console.WriteLine("Informe a nota do aluno \t");
var nota = Convert.ToInt32(Console.ReadLine());

if (nota > 5)
    Console.WriteLine("Aluno Aprovado");

else
    Console.WriteLine("Aluno Reprovado");

Console.WriteLine("Fim do processamento aluno...\n");

Console.WriteLine("Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe o valor de y\t");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{

    Console.WriteLine("x é maior do que y");

} else
{
    
    if (x < y)
    {

        Console.WriteLine("x é menor do que y");

    } else
    {
        Console.WriteLine("x é igual a y");
    }

}

Console.ReadKey();