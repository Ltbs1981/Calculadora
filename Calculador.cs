using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMCalculadora
{
    public static class Calculador
    {
        public static double Soma(double numero1, double numero2) => numero1 + numero2;

        public static double Subtracao(double numero1, double numero2) => numero1 - numero2;

        public static double Multiplicacao(double numero1, double numero2) => numero1 * numero2;

        public static double Divisao(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                Console.WriteLine("O divisor não pode ser zero!");
                return 0;
            }
            return numero1 / numero2;
        }

        public static double Raiz(double numero)
        {
            if (numero < 0)
            {
                Console.WriteLine("Não é possível calcular a raiz quadrada de um número negativo.");
                return 0;
            }
            return Math.Sqrt(numero);
        }
    }
}