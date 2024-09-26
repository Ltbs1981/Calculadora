using System;

namespace SCMCalculadora
{
    public class CalculadoraPadrao
    {
        public double Numero1 { get; set; }
        public double Numero2 { get; set; }

        public CalculadoraPadrao(double numero1, double numero2)
        {
            Numero1 = numero1;
            Numero2 = numero2;
        }

        public double Soma() => Numero1 + Numero2;

        public double Subtracao() => Numero1 - Numero2;

        public double Multiplicacao() => Numero1 * Numero2;

        public double Divisao()
        {
            if (Numero2 == 0)
            {
                Console.WriteLine("O divisor não pode ser zero!");
                return 0;
            }
            else
            {
                return Numero1 / Numero2;
            }
        }
    }
}
