namespace Algoritmos_Aprendizagem.Recursao.Fatorial
{
    public class Fatorial
    {
        public static int Fat(int x)
        {
            if (x == 1)
                return 1;
            else
                return x * Fat(x - 1);          
        }      
    }
}