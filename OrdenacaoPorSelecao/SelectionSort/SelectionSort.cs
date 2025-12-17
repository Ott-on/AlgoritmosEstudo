namespace Algoritmos_Aprendizagem.OrdenacaoPorSelecao.SelectionSort
{
    public class SelectionSort
    {
        public static int BuscaMenor(IList<int> lista)
        {
            var menor = lista[0];
            var menorIndice = 0;

            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] < menor)
                {
                    menor = lista[i];
                    menorIndice = i;
                }
            }

            return menorIndice;
        }

        public static int[] OrdenacaoPorSelecao(IList<int> lista)
        {
            var novaLista = new int[lista.Count];

            for (int i = 0; i < novaLista.Length; i++)
            {
                var menor = BuscaMenor(lista);
                novaLista[i] = lista[menor];
                lista.RemoveAt(menor);
            }

            return novaLista;  
        }
    }
}