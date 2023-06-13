using ByteBankArrays.Modelos.Conta;

namespace ByteBankArray.SistemaAgencia
{
    public class ListaContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaContaCorrente()
        {
            _itens = new ContaCorrente[5];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {

            VerificarCapacidade(_proximaPosicao + 1);

            Console.WriteLine($"Adocionando item na posição {_proximaPosicao}\n");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine("Aumentando a capacidade da lista!\n");

            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0; i < _itens.Length; i++)
            {
                novoArray[i] = _itens[i];
                Console.WriteLine(".");
            }

            _itens = novoArray;            
        }
    }
}