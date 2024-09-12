using System;
using SCMCalculadora;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Padrão");
        CalculadoraPadrao operacao1 = new CalculadoraPadrao(12, 5);
        operacao1.Calculando4Operacoes();

        Console.WriteLine("\nCalculadora Científica");
        CalculadoraCientifica operacao2 = new CalculadoraCientifica(16, 9);
        operacao2.Calculando4Operacoes();
        operacao2.RaizQuadrada();

        CalculadoraCientifica operacao3 = new CalculadoraCientifica(65536);
        operacao3.RaizQuadrada();

    }
}
