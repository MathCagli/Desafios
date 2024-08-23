namespace Desafios.ProjectEuler;

/* https://projecteuler.net/problem=7 */
public static class Problema_7
{
    public static void Solucao()
    {
        int num = 1;
        int qtdPrimos = 0;
        while (true)
        {
            num++;
            if (Utilitario.VerificarPrimo(num))
            {
                qtdPrimos++;
                if (qtdPrimos == 10001) Console.WriteLine($"O Número Primo 10001: {num}");
            }
        }
    }
}