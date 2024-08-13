namespace Desafios.CodeWars;

public static class Kata_2
{
    /* https://www.codewars.com/kata/5b077ebdaf15be5c7f000077 */
    public static void Solucao()
    {
        int num = 10;
        string retorno = "";
        string s = " ovelha...";

        for (int i = 1; i <= num; i++) retorno += i.ToString() + s;
        Console.WriteLine(retorno);
    }
}