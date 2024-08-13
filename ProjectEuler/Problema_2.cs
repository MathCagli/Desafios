namespace Desafios.ProjectEuler;

/* https://projecteuler.net/problem=2 */
public static class Problema_2
{
    public static void Solucao()
    {
        List<int> fib = new List<int>() { 1, 1 };
        int soma = 0;
        int num = 0;

        while (true)
        {
            num = fib[fib.Count - 2] + fib[fib.Count - 1];
            if (num < 3999999)
            {
                fib.Add(num);
                if (num % 2 == 0) soma += num;
                Console.WriteLine("Fibonacci: " + fib.Last());
            }
            else { break; }
        }

        Console.WriteLine("Soma dos Fibonaccis Pares: " + soma);
    }
}