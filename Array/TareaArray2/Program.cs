namespace TareaArray2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompararMatrices compararMatrices = new CompararMatrices();

            var matriz1 = compararMatrices.ImprimirMatriz1();
            var matriz2 = compararMatrices.ImprimirMatriz2();
            compararMatrices.ComparacionMatrices(matriz1, matriz2);
            
        }
    }
}
