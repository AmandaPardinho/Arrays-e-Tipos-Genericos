using ByteBankArrays.Modelos.Conta;

namespace ByteBankArray.SistemaAgencia
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        /* argumentos opcionais => são parâmetros que possuem um valor pré-definido na sobrecarga do método ou construtor
         * para mudar o valor de um argumento opcional basta que, ao chamar o método ao qual ele pertence, seja colocado o nome do argumento + : + novo valor (por exemplo método meuMetodo(string texto = "oi", int numero = 5) => meuMetodo(numero:5))
         */
        public ListaContaCorrente(int capacidadeInicial = 5)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {

            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adocionando item na posição {_proximaPosicao}\n");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        public void Remover(ContaCorrente item)
        {
            int indiceItem = -1;
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente itemAtual = _itens[i];
                if (itemAtual.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }

            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public void EscreverListaNaTela()
        {
            for (int i = 0; i < _proximaPosicao; i++)
            {
                ContaCorrente conta = _itens[i];
                Console.WriteLine(conta);
            }
        }
        

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if(novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            Console.WriteLine("Aumentando a capacidade da lista!\n");

            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
                Console.WriteLine(".");
            }

            _itens = novoArray;            
        }
    }
}