using Algoritmos_Aprendizagem.IntroducaoAlgoritmos;
using Algoritmos_Aprendizagem.ListaEncadeada;
using Algoritmos_Aprendizagem.OrdenacaoPorSelecao.DoubleSelectionSort;
using Algoritmos_Aprendizagem.OrdenacaoPorSelecao.SelectionSort;
using Algoritmos_Aprendizagem.Recursao.Contagem;
using Algoritmos_Aprendizagem.Recursao.Fatorial;
using Algoritmos_Aprendizagem.Recursao.Fibonacci;
using Algoritmos_Aprendizagem.Recursao.Regressiva;
using Algoritmos_Aprendizagem.Recursao.Soma;
using Algoritmos_Aprendizagem.Recursao.ValorMaisAltoNaLista;

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

// Recursão
Regressiva.ContagemRegressiva(5);
Console.WriteLine($"Fatorial: {Fatorial.Fat(5)}");

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine(Fibonacci.Fibo(i));
}

int[] arr = [2, 4, 6];

Console.WriteLine($"Soma recursiva = {Soma.FuncaoSoma(arr)}");

int[] array = [1, 5, 7, 10];
Console.WriteLine($"Contagem de números = {ContagemNumeros.Contagem(array)}");

int[] valorMaior = [3, 2, 30, 6, 8, 10];
Console.WriteLine($"Valor mais alto = {ValorMaisAltoNaLista.EncontrarValorMaisAlto(valorMaior)}");

