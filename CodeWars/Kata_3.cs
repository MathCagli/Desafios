namespace Desafios.CodeWars;

/* https://www.codewars.com/kata/59dd3ccdded72fc78b000b25 */
public static class Kata_3
{
    public static void Solucao()
    {

        Console.Write("Enter a Number: ");

        int num = int.Parse(Console.ReadLine()!);
        var retorno = "";
        switch (num)
        {
            case 1:
                retorno = "Sunday";
                break;
            case 2:
                retorno = "Monday";
                break;
            case 3:
                retorno = "Tuesday";
                break;
            case 4:
                retorno = "Wednesday";
                break;
            case 5:
                retorno = "Thursday";
                break;
            case 6:
                retorno = "Friday";
                break;
            case 7:
                retorno = "Saturday";
                break;
            default:
                retorno = "Wrong, please enter a number between 1 and 7";
                break;
        }

        Console.WriteLine(retorno);
    }
}
