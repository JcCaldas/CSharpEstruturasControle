Console.WriteLine("## Exercício 09 ##\n");

int num1 = 2, num2 = 1;

do
{
    Console.WriteLine($"\nTabuada do {num1}:");
    do
    {
        Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
        num2++;
    } while (num2 <= 10);
    num2 = 1;
    num1++;

} while (num1 <= 6);