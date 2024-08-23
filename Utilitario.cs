namespace Desafios;

public static class Utilitario
{
    public static bool VerificarPrimo(long n)
    {
        if (n <= 1) return false;
        if (n <= 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;
        for (int i = 5; i * i <= n; i += 6) if (n % i == 0 || n % (i + 2) == 0) return false;
        return true;
    }

    public static long MaiorFatorPrimo(long n)
    {
        long retorno = 1;

        while (n % 2 == 0)
        {
            retorno = 2;
            n /= 2;
        }

        for (long i = 3; i * i <= n; i += 2)
        {
            while (n % i == 0)
            {
                retorno = i;
                n /= i;
            }
        }

        if (n > 2)
        {
            retorno = n;
        }

        return retorno;
    }
}