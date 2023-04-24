Console.WriteLine("## Exercício 05 ##\n");

string resp;
bool repeticao = true;

while (repeticao)
{

    Console.WriteLine("\nQual a instrução para sair de um loop?");
    Console.WriteLine("a. quit");
    Console.WriteLine("b. continue");
    Console.WriteLine("c. break");
    Console.WriteLine("d. exit");

    Console.Write("\nQual a opção correta? (Tecle \"x\" para sair) -> ");
    resp = Console.ReadLine().ToLower();

    if (resp == "c")
    {

        Console.WriteLine("Resposta Correta");
        repeticao = false;

    }   
    else if (resp == "x")
    {
        
        repeticao = false;

    }
    else
    {
    
        Console.WriteLine("Resposta incorreta");

    }
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();