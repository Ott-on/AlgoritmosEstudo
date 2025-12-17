namespace Algoritmos_Aprendizagem.ListaEncadeada
{
    public class LinkedList
    {
        public Node? Head;
        public int Tamanho;

        public LinkedList()
        {
            Head = null;
            Tamanho = 0;
        }

        public void Add(int valor)
        {
            var novoNode = new Node(valor);

            if (Head == null)
            {
                Head = novoNode;

            } else {
                var atual = Head;

                while(atual.Proximo != null)
                {
                    atual = atual.Proximo;     
                }

                atual.Proximo = novoNode;   
            }

            Tamanho++;
        }

        public void Print()
        {
            var atual = Head;

            while (atual != null)
            {
                Console.Write(atual.Valor + " -> ");
                atual = atual.Proximo;
            }

            Console.WriteLine("null");
        }  
    }
}