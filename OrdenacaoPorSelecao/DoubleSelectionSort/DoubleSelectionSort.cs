using System.Collections;

namespace Algoritmos_Aprendizagem.OrdenacaoPorSelecao.DoubleSelectionSort
{
    public class DoubleSelectionSort
    {
        public static int[] OrdenacaoDuplaPorSelecao(int[] array)
        {
            return OrdenacaoDuplaPorSelecao(new LinkedList<int>(array)).ToArray();
        }

        private static IEnumerable<int> OrdenacaoDuplaPorSelecao(LinkedList<int> lista)
        {
            var maxLista = new LinkedList<int>();
            var minLista = new LinkedList<int>();

            while (lista.Count != 0)
            {
                var min = lista.Min();
                lista.Remove(min);
                minLista.AddLast(min);

                if (lista.Count > 0)
                {
                    var max = lista.Max();
                    lista.Remove(max);
                    maxLista.AddFirst(max);   
                }
            }

            return minLista.Union(maxLista);

        }
    }
}