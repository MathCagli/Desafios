namespace Desafios.ProjectEuler;

/* https://projecteuler.net/problem=10 */
public static class Problema_10
{
    public static void Solucao()
    {
        int num = 1;
        long soma = 0;
        do
        {
            num++;
            if (Utilitario.VerificarPrimo(num))
            {
                Console.WriteLine($"{num} é um número primo.");
                soma += num;
            }
        }
        while (num < 2000000);
        Console.WriteLine($"Soma Total: {soma}");
    }
}