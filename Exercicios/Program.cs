Console.WriteLine("### Exercício 01 ###\n");

int num, maior = 0;
bool continuar = true;
string resposta;

while (continuar)
{

    for (int i = 1; i <= 3; i++)
    {
        Console.WriteLine($"\nDigite o {i}º número: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (i == 1)
        {

            maior = num;

        }
        else
        {
            if (num > maior)
            {
                maior = num;
            }
        }
    }

    Console.WriteLine($"O maior número digitado foi {maior}.\n");

    Console.WriteLine("Quer fazer novamente? (S/N)");
    resposta = Console.ReadLine().ToLower();

    if (resposta == "n")
        continuar = false;
}
Console.ReadKey();