using System;
using SCMCalculadora;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Calculadora Padrão");
        CalculadoraPadrao operacao1 = new CalculadoraPadrao(12, 5);
        operacao1.Calculando4Operacoes();
    }
}
}
}