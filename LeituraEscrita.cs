using Desafios.CodeWars;
using Desafios.ProjectEuler;

namespace Desafios;

public static class LeituraEscrita
{
    public static void Escrever()
    {
        Console.Clear();
        Console.WriteLine("BEM VINDO AO PROJETO DE DESAFIO!!!");
        Console.WriteLine("Escolha a Fonte dos Desafios.");
        Console.WriteLine("1- Project Euler");
        Console.WriteLine("2- CodeWars");
        Console.WriteLine("0- Sair");

        int respostaFonte = ValidarEscrita(Console.ReadLine()!);

        if (respostaFonte == 1) SelecionarProjectEuler();
        if (respostaFonte == 2) SelecionarCodeWars();
    }

    private static void SelecionarProjectEuler()
    {
        Console.Write("Escolha o Número do Desafio Entre 1, 2, 3, 5, 6, 7 e 10: ");
        int respostaDesafio = ValidarEscrita(Console.ReadLine()!);

        switch (respostaDesafio)
        {
            case 1:
                Problema_1.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            case 2:
                Problema_2.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            case 3:
                Problema_3.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            case 5:
                Problema_5.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            case 6:
                Problema_6.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            case 7:
                Problema_7.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            case 10:
                Problema_10.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            default:
                break;
        }
    }

    private static void SelecionarCodeWars()
    {
        Console.Write("Escolha o Número do Desafio Entre 1, 2 e 3: ");
        int respostaDesafio = ValidarEscrita(Console.ReadLine()!);

        switch (respostaDesafio)
        {
            case 1:
                Kata_1.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            case 2:
                Kata_2.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            case 3:
                Kata_3.Solucao();
                Console.WriteLine("Pressione Qualquer Tecla Para Voltar ao Início.");
                Console.ReadKey();
                Escrever();
                break;
            default:
                break;
        }
    }

    public static int ValidarEscrita(string texto)
    {
        do
        {
            bool valida = int.TryParse(texto, out int retorno);
            if (!valida)
            {
                Console.Write("Por Favor, Escreva Apenas Números! ");
                texto = Console.ReadLine()!;
            }
            else return retorno;
        }
        while (true);
    }
}