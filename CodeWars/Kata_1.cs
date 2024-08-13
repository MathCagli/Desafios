namespace Desafios.CodeWars;

public static class Kata_1
{
    /* https://www.codewars.com/kata/5ab6538b379d20ad880000ab */
    public static void Solucao()
    {
        int num1 = 6;
        int num2 = 10;

        if (num1 == num2) Console.WriteLine("A Àrea do Quadrado é: " + (num1 * num2));
        else Console.WriteLine("O Perímetro do Retângulo é: " + (2 * (num1 + num2)));
    }
}