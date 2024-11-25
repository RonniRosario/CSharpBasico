namespace EjemploForEach
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arreglo = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
            int total = 0;

            //suma el valor de cada elemento a total
            foreach (int numero in arreglo)
            {
                total += numero;
            }

            Console.WriteLine("Total de elementos en el arreglo: {0}",total);
        }
    }
}
