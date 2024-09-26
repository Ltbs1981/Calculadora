using SCMCalculadora;
using System;

class Program
{
    static void Main(string[] args)
    {
        CalculadoraPadrao operacao1 = new(5.9, 9.3);
        Console.WriteLine($"Resultado da soma: {Math.Round(operacao1.Soma(), 2)}");
        Console.WriteLine($"Resultado da subtração: {Math.Round(operacao1.Subtracao(), 2)}");
        Console.WriteLine($"Resultado da divisão: {Math.Round(operacao1.Divisao(), 2)}");
        Console.WriteLine($"Resultado da multiplicação: {Math.Round(operacao1.Multiplicacao(), 2)}");

        CalculadoraCientifica operacao2 = new(25, 9, 81);
        Console.WriteLine($"Resultado da raiz quadrada: {Math.Round(operacao2.Raiz(), 2)}");
        Console.WriteLine($"Resultado da soma (herdado da CalculadoraPadrao): {Math.Round(operacao2.Soma(), 2)}");
    }
}
