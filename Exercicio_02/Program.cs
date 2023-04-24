Console.WriteLine("## Exercício 02 ##\n");

double a, b, c, xpos, xneg, d;

Console.WriteLine("Cálculo da equação do segundo grau (ax²+bx+c)\n");

Console.Write("Informe o valor de a: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor de b: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Informe o valor de c: ");
c = Convert.ToDouble(Console.ReadLine());

d = (Math.Pow(b, 2)) - (4 * a * c);

if (d < 0)
{
    Console.WriteLine("Sem solução para os números reais informados.");
} else
{
    xpos = (-b + Math.Sqrt(d)) / 2 * a;
    xneg = (-b - Math.Sqrt(d)) / 2 * a;
    Console.WriteLine($"X1: {xpos}");
    Console.WriteLine($"X2: {xneg}");
}



Console.ReadKey();