﻿using System;
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
            Lista<int> idades = new Lista<int>();

            idades.Adicionar(5);
            idades.AdicionarVarios(1, 5, 78);

            int idadeSoma = 0;
            for(int i = 0; i < idades.Tamanho; i++)
            {
                int idadeAtual = idades[i];
                Console.WriteLine(idadeAtual);
            }

            Console.WriteLine(SomarVarios(1, 2, 3, 5, 56465, 45));
            Console.WriteLine(SomarVarios(1, 2, 45));

            Console.ReadKey();
        }

        static void TestaListaObject()
        {
            ListaObject listaIdades = new ListaObject();

            listaIdades.Adicionar(10);
            listaIdades.Adicionar(5);
            listaIdades.Adicionar(4);
            listaIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaIdades.Tamanho; i++)
            {
                int idade = (int)listaIdades[i];
                Console.WriteLine($"Idade no índice {i}: {idade} anos");
            }
        }

        static int SomarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros) 
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaDeConta()
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

            ContaCorrente conta = new ContaCorrente(023, 0000001);
            lista.Adicionar(conta);
            Console.WriteLine("Conta 'conta' foi adicionada");
            Console.WriteLine();
            lista.EscreverListaNaTela();
            Console.WriteLine();
            lista.Remover(conta);
            Console.WriteLine("Conta 'conta' foi removida");
            Console.WriteLine();
            lista.EscreverListaNaTela();
            Console.WriteLine();

            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente novoItem = lista.GetItemNoIndice(i);
                Console.WriteLine($"Item na posição {i} = Conta {novoItem.Numero}/{novoItem.Agencia}\n");
            }

            ContaCorrente[] contasParaAdicionar = new ContaCorrente[]
            {
                new ContaCorrente(874, 7781438),
                new ContaCorrente(874, 3379781),
                new ContaCorrente(874, 1056228),
                new ContaCorrente(874, 8881432),
                new ContaCorrente(874, 5679755),
                new ContaCorrente(874, 3156298),
                new ContaCorrente(874, 7481266)
            };

            lista.AdicionarVarios(contasParaAdicionar);
            lista.AdicionarVarios(
                new ContaCorrente(874, 7781438),
                new ContaCorrente(874, 3379781),
                new ContaCorrente(874, 1056228),
                new ContaCorrente(874, 8881432),
                new ContaCorrente(874, 5679755),
                new ContaCorrente(874, 3156298),
                new ContaCorrente(874, 7481266)
                );
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