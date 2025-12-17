using Algoritmos_Aprendizagem.IntroducaoAlgoritmos;
using Algoritmos_Aprendizagem.ListaEncadeada;
using Algoritmos_Aprendizagem.OrdenacaoPorSelecao.DoubleSelectionSort;
using Algoritmos_Aprendizagem.OrdenacaoPorSelecao.SelectionSort;

// Pesquisa Binária
IList<int> listaPesquisaBinaria = [1, 3, 5, 7, 9];

Console.WriteLine(PesquisaBinaria.PesquisaBinariaFuncao(listaPesquisaBinaria, 3)?.ToString() ?? "null");
Console.WriteLine(PesquisaBinaria.PesquisaBinariaFuncao(listaPesquisaBinaria, -1)?.ToString() ?? "null");

// Lista Encadeada
var listaEncadeada = new LinkedList();
listaEncadeada.Add(2);
listaEncadeada.Add(5);
listaEncadeada.Add(7);

Console.WriteLine($"Tamanho da lista: {listaEncadeada.Tamanho}");
listaEncadeada.Print();

// Ordenacao por Seleção
IList<int> listaOrdenacaoPorSelecao = [5, 3, 6, 2, 10];
int[] listaOrdenacaoDuplaPorSelecao = [10, 4, 7, 2, 9, 11];

Console.WriteLine($"Lista ordenada por seleção: {(string.Join(", ", SelectionSort.OrdenacaoPorSelecao(listaOrdenacaoPorSelecao)))}");
Console.WriteLine($"Lista ordenada por seleção dupla: {(string.Join(", ", DoubleSelectionSort.OrdenacaoDuplaPorSelecao(listaOrdenacaoDuplaPorSelecao)))}");

