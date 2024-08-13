namespace Desafios.ProjectEuler;

/* https://projecteuler.net/problem=5 */
public static class Problema_5
{
    public static void Solucao()
    {
        int num = 20;

        while (true)
        {
            num++;
            if (num % 11 == 0 && num % 12 == 0 && num % 13 == 0 && num % 14 == 0 && num % 15 == 0 &&
                num % 16 == 0 && num % 17 == 0 && num % 18 == 0 && num % 19 == 0 && num % 20 == 0) break;
        }

        Console.WriteLine("O Menor Número Divisível Por 1 a 20 é: " + num);
    }
}