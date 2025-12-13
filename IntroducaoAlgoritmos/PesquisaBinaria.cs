namespace Algoritmos_Aprendizagem.IntroducaoAlgoritmos
{
    public class PesquisaBinaria
    {
        public static int? PesquisaBinariaFuncao(IList<int> lista, int item)
        {
            var baixo = 0;
            var alto = (lista.Count) - 1;

            while (baixo <= alto)
            {
                var meio = (baixo + alto) / 2;
                var chute = lista[meio];
                
                if (chute == item)
                    return meio;
                if (chute > item)
                    alto = meio - 1;
                else
                    baixo = meio + 1;
            }

            return null;
        }
    }
}