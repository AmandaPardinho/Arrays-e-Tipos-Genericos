using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ArraysTiposGenericos
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* o tipo array é um tipo de referência;
             * no entanto, ao acessar uma posição do array, estamos pegando o valor contido nessa posição e, por isso, ele pode ser referenciado por uma variável do tipo int;
             * 
             */
            //array de inteiros com 5 posições
            //int[] idades = null;
            int[] idades = new int[5];

            idades[0] = 15;
            idades[1] = 28;
            idades[2] = 35;
            idades[3] = 50;
            idades[4] = 28;
            /* Ao excluir/comentar uma posição que existe no array, o retorno será zero (retorno padrão do tipo int)
             * isso acontece pois o compilador entende que essa posição apenas não foi inicializada
             */

            int idadeNoIndiceQuatro = idades[4];

            Console.WriteLine(idadeNoIndiceQuatro);

            int[] outroArray = idades;
            Console.WriteLine(outroArray[3]);

            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Acessando o array idades no índice {i} e obtendo o valor {idade} anos para a idade[{i}]\n");

                acumulador += idade;
            }

            int media = acumulador / 5;
            Console.WriteLine($"Média de idades = {media} anos");

            Console.ReadKey();
        }
    }
}

