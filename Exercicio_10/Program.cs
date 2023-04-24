Console.WriteLine("## Exercício 09 ##\n");

int num;
Console.Write("Digite a nota do Aluno: ");
num = Convert.ToInt32(Console.ReadLine());

switch (num) {

    case 10:
        Console.WriteLine("Equivale a nota A+");
        break;

    case 9:
        Console.WriteLine("Equivale a nota A");
        break;
    
    case 8:
    case 7:
        Console.WriteLine("Equivale a nota B");
        break;
    
    case 6:
        Console.WriteLine("Equivale a nota C");
        break;
    
    case 5:
        Console.WriteLine("Equivale a nota E");
        break;

    case 4:
    case 3:
    case 2:
    case 1:
    case 0:
        Console.WriteLine("Equivale a nota F");
        break;

    default:
        Console.WriteLine("A nota informada é inválida!");
        break;
};

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();