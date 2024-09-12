using System;

namespace SCMCalculadora
{
    
    public class CalculadoraCientifica : CalculadoraPadrao
    {

public CalculadoraCientifica(int numero_1) : base(numero_1) { }        
        public CalculadoraCientifica(int numero_1, int numero_2) : base(numero_1, numero_2) { }


        public void RaizQuadrada()
        {
            Console.WriteLine($"Raiz quadrada de {Numero_1}: {Math.Sqrt(Numero_1)}");
            Console.WriteLine($"Raiz quadrada de {Numero_2}: {Math.Sqrt(Numero_2)}");
        }
    }
}
