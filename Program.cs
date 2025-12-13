using Algoritmos_Aprendizagem.IntroducaoAlgoritmos;

// Pesquisa Binária
IList<int> lista = [1, 3, 5, 7, 9];

Console.WriteLine(PesquisaBinaria.PesquisaBinariaFuncao(lista, 3)?.ToString() ?? "null");
Console.WriteLine(PesquisaBinaria.PesquisaBinariaFuncao(lista, -1)?.ToString() ?? "null");

