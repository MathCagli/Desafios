namespace Desafios.ProjectEuler;

/* https://projecteuler.net/problem=3 */
public static class Problema_3
{
    public static void Solucao()
    {
        long num = 600851475143;
        long maiorFator = Utilitario.MaiorFatorPrimo(num);
        Console.WriteLine($"{maiorFator} é o maior fator primo de 600851475143 ");
    }
}