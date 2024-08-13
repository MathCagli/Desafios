namespace Desafios.ProjectEuler;

public static class Problema_1
{
    /* https://projecteuler.net/problem=1 */
    public static void Solucao()
    {
        int num = 0;
        int soma = 0;

        do
        {
            num++;

            if (num % 3 == 0)
            {
                soma += num;
                Console.WriteLine(num + " é Divisível Por 3");
            }
            else if (num % 5 == 0)
            {
                soma += num;
                Console.WriteLine(num + " é Divisível Por 5");
            }
        }
        while (num < 999);

        Console.WriteLine("Soma Igual: " + soma);
    }

}