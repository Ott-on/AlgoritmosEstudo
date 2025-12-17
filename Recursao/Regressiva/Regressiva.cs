namespace Algoritmos_Aprendizagem.Recursao.Regressiva
{
    public class Regressiva
    {
        public static void ContagemRegressiva(int i)
        {
            Console.WriteLine(i);
            
            // caso base
            if (i <= 0) return;

            // caso recursivo
            ContagemRegressiva(i - 1);
        }
    }
}