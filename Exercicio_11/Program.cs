Console.WriteLine("## Exercício 11 ##");

double num1, num2, resultado;
string operando, resp;

Console.WriteLine("Calculadora Simples:");

while (true)
{
    Console.Write("Digite o primeiro número: ");
    num1 = Convert.ToDouble(Console.ReadLine());

    while (true)
    {
        Console.Write("Digite o operando (+, -, *, /): ");
        operando = Console.ReadLine();

        if (operando == "+" || operando == "-" || operando == "*" || operando == "/")
        {
            
            break;

        }
        else
        {
                 
            Console.WriteLine("Operando inválido!");

        }

    }

    Console.Write("Digite o segundo número: ");
    num2 = Convert.ToDouble(Console.ReadLine());

    if (operando == "/" && num2 == 0)
    {

        Console.WriteLine($"Não existe divisão por 0!");

    }
    else
    {
        if (operando == "+")
        {
            resultado = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {resultado}");

        }
        else if (operando == "-")
        {
            resultado = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {resultado}");

        }
        else if (operando == "*")
        {
            resultado = num1 * num2;
            Console.WriteLine($"{num1} X {num2} = {resultado}");

        }
        else if (operando == "/")
        {
            resultado = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {resultado}");
        }
    }


    Console.WriteLine("\nQuer fazer outra operação? (S/N)");
    resp = Console.ReadLine().ToLower();

    if (resp == "n")
        break;
}

Console.WriteLine("\nFim do processamento...");

Console.ReadKey();