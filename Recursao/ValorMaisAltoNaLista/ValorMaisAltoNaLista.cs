namespace Algoritmos_Aprendizagem.Recursao.ValorMaisAltoNaLista;

public class ValorMaisAltoNaLista
{
    public static int EncontrarValorMaisAlto(int[] array)
    {
        if (array.Length == 0)
            throw new ArgumentException("Array vazio");

        if (array.Length == 1)
            return array[0];

        int maiorDoResto = EncontrarValorMaisAlto(array.Skip(1).ToArray());

        return array[0] > maiorDoResto ? array[0] : maiorDoResto;
    }  
}
