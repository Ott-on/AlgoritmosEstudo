namespace Algoritmos_Aprendizagem.Recursao.Soma;

public class Soma
{
    public static int FuncaoSoma(int[] array)
    {
        if (array.Length == 0)
            return 0;
    
        return array[0] + FuncaoSoma(array.Skip(1).ToArray());     
    }    
}
