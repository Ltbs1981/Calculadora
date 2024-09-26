using System;
using SCMCalculadora;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Raiz Quadrada");
            Console.WriteLine("0 - Sair");

            Console.Write("Digite o número da operação: ");
            int operacao = int.Parse(Console.ReadLine());

            if (operacao == (int)Operacoes.Sair)
            {
                break;
            }

            if (operacao < 0 || operacao > 5)
            {
                Console.WriteLine("Opção inválida, tente novamente.");
                continue;
            }

            double numero1 = 0, numero2 = 0, resultado = 0;

            if (operacao != (int)Operacoes.Raiz)
            {
                Console.Write("Digite o primeiro número: ");
                numero1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                numero2 = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.Write("Digite o número para a raiz quadrada: ");
                numero1 = double.Parse(Console.ReadLine());
            }

            switch ((Operacoes)operacao)
            {
                case Operacoes.Soma:
                    resultado = Calculador.Soma(numero1, numero2);
                    Console.WriteLine($"Resultado da soma: {Math.Round(resultado, 2)}");
                    break;
                case Operacoes.Subtracao:
                    resultado = Calculador.Subtracao(numero1, numero2);
                    Console.WriteLine($"Resultado da subtração: {Math.Round(resultado, 2)}");
                    break;
                case Operacoes.Multiplicacao:
                    resultado = Calculador.Multiplicacao(numero1, numero2);
                    Console.WriteLine($"Resultado da multiplicação: {Math.Round(resultado, 2)}");
                    break;
                case Operacoes.Divisao:
                    resultado = Calculador.Divisao(numero1, numero2);
                    Console.WriteLine($"Resultado da divisão: {Math.Round(resultado, 2)}");
                    break;
                case Operacoes.Raiz:
                    resultado = Calculador.Raiz(numero1);
                    Console.WriteLine($"Resultado da raiz quadrada: {Math.Round(resultado, 2)}");
                    break;
                default:
                    break;
            }
        }
    }
}
