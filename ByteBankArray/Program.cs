using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ByteBankArrays.Modelos.Conta;

namespace ByteBankArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438)
            };           

            for(int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }

            Console.ReadKey();
        }
    }
}