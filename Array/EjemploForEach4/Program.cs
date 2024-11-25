
namespace EjemploForEach4
{
    internal class Program
    {
        //crea e imprime arreglos rectangulares y dentados 
        public static void Main(string[] args)
        {
            int[,] rectangular = { { 1, 2, 3 }, { 4, 5, 6 } };

            int[][] dentado = {new int[] { 1, 2 },
                               new int[] { 3},
                               new int[] {4,5,6 } };
            
            ImprimirArreglo(rectangular);
            Console.WriteLine();
            ImprimirArreglo(dentado);
        }

        public static void ImprimirArreglo(int[,] arreglo)
        {
            Console.WriteLine("Los valores en el arreglo rectangular por fila son");

            for (int fila = 0; fila < arreglo.GetLength(0); fila++)
            {
                for (int columna = 0; columna < arreglo.GetLength(1); columna++)
                    Console.Write("{0}  ", arreglo[fila, columna]);

                Console.WriteLine();
            }

        }

        public static void ImprimirArreglo(int[][] arreglo)
        {
            Console.WriteLine("Los valores en el arreglo dentado por fila son");

            for (int fila = 0;fila < arreglo.Length; fila++)
            {
                for (int columna = 0; columna< arreglo[fila].Length; columna++)
                {
                    Console.Write("{0}  ", arreglo[fila][columna]);
                }
            Console.WriteLine();
            }
        }
    }
}
