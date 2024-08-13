namespace Desafios.ProjectEuler;

/* https://projecteuler.net/problem=6 */
public static class Problema_6
{
    public static void Solucao()
    {
        int somaQuadrado = 0;
        int quadradoSoma = 0;

        for (int num = 0; num <= 10; num++)
        {
            somaQuadrado += num * num;
            quadradoSoma += num;
        }
        quadradoSoma = quadradoSoma * quadradoSoma;

        Console.WriteLine("A Soma dos Quadrados é: " + somaQuadrado);
        Console.WriteLine("O Quadrado da Soma é: " + quadradoSoma);
        Console.WriteLine("A Diferença Entre a Soma dos Quadrados e o Quadrado da Soma é: " + (quadradoSoma - somaQuadrado));
    }
}