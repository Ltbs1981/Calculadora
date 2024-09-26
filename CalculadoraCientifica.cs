using System;

namespace SCMCalculadora
{
    public class CalculadoraCientifica : CalculadoraPadrao
    {
        public double Numero3 { get; set; }

        public CalculadoraCientifica(double numero1, double numero2, double numero3) : base(numero1, numero2)
        {
            Numero3 = numero3;
        }

        public double Raiz() => Math.Sqrt(Numero3);
    }
}
