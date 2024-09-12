using System;

namespace SCMCalculadora
{
    public class CalculadoraPadrao
    {
        public int Numero_1 { get; set; }
        public int Numero_2 { get; set; }

        
        public CalculadoraPadrao(int numero_1)
        {
            Numero_1 = numero_1;
        }


        public CalculadoraPadrao(int numero_1, int numero_2)
        {
            Numero_1 = numero_1;
            Numero_2 = numero_2;
        }

        
        public virtual void Calculando4Operacoes()
        {
            Console.WriteLine($"Soma: {Numero_1 + Numero_2}");
            Console.WriteLine($"Subtração: {Numero_1 - Numero_2}");
            Console.WriteLine($"Multiplicação: {Numero_1 * Numero_2}");
            Console.WriteLine($"Divisão: {Numero_1 / Numero_2}");
    }
}
