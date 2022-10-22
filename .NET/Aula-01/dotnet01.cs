// Aula 1 de .NET com C#, do dia 08/10/2022, com o professor Rodolfo Pedra, modificada. Ele fez de um jeito, e acabei modificando por ter escrito em um notebook emprestado

using System;

namespace Program1
{
    public class MinhaAplicacao
    {
        static void Main(string[] args)
        {
            MinhaClasse m = new MinhaClasse();
            Console.WriteLine(m.Soma(100, 0));
        }
    }
    public class MinhaClasse
    {
        public int Soma(int a, int b)
        {
            return a + b;
        }
    }
}