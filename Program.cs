using System;

    public class PrimeirPrograma
{
    public static void Main(string[] args)
    {

        int valor1 = 22;
        int valor2 = 23;


        int soma = valor1 + valor2;
        int subtracao = valor1 - valor2;
        int multiplicacao = valor1 * valor2;
        int divisao = valor1 / valor2;
        int resto = valor1 % valor2;



        Console.WriteLine("sua soma vai dar: " + soma);
        Console.WriteLine("sua subtração vai dar: " + subtracao);
        Console.WriteLine("sua multiplicação vai dar: " + multiplicacao);
        Console.WriteLine("sua divisão vai dar: " + divisao);
        Console.WriteLine("seu resto vai dar: " + resto);

    }

}