Console.WriteLine("## Estrutura Switch-case ##\n");

Console.WriteLine("Informe um mês:");
var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maio":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;
    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;
    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

Console.WriteLine("\nFim do processamento mês...\n");

int cargo = 0, funcao = 0;
Console.WriteLine("Você é Gerente(1) ou Programador(2)? \t");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
    Console.WriteLine("Você é Júnior(1) ou Sênior(2)?\t");
    funcao = Convert.ToInt32(Console.ReadLine());

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem-Vindo Gerente!");
        break;
    case 2:
        Console.WriteLine("\nBem-Vindo Programador!");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é Júnior!");
                break;
            case 2:
                Console.WriteLine("\nVocê é Sênior!");
                break;
            default:
                Console.WriteLine("\nFunção Desconhecida!");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consigo te identificar!");
        break;
}

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();