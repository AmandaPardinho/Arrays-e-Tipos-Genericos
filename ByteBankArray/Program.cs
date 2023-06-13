using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ByteBankArray.SistemaAgencia;
using ByteBankArrays.Modelos.Conta;

namespace ByteBankArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaContaCorrente lista = new ListaContaCorrente();
            lista.Adicionar(new ContaCorrente(874, 5679787));
            lista.Adicionar(new ContaCorrente(874, 4456668));
            lista.Adicionar(new ContaCorrente(874, 7781438));
            lista.Adicionar(new ContaCorrente(874, 3379781));
            lista.Adicionar(new ContaCorrente(874, 1056228));
            lista.Adicionar(new ContaCorrente(874, 8881432));
            lista.Adicionar(new ContaCorrente(874, 5679755));
            lista.Adicionar(new ContaCorrente(874, 3156298));
            lista.Adicionar(new ContaCorrente(874, 7481266));

            Console.ReadKey();
        }

        static void TestaArrayContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 4456668),
                new ContaCorrente(874, 7781438)
            };

            for (int i = 0; i < contas.Length; i++)
            {
                ContaCorrente contaAtual = contas[i];
                Console.WriteLine($"Conta {i} {contaAtual.Numero}");
            }

            Console.ReadKey();
        }
    }
}