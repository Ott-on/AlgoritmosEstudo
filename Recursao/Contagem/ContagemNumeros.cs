namespace Algoritmos_Aprendizagem.Recursao.Contagem
{
    public class ContagemNumeros
    {
        public static int Contagem(int[] array)
        {       
            if (array.Length == 0)
                return 0;

            if (array.Length == 1)
                return 1;
            
            return Contagem(array.Skip(1).ToArray()) + 1;
               
        }    
    }
}