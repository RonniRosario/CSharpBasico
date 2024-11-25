namespace EjemploForEach3
{
    internal class PruebaReferenciaArreglo
    {
        public static void Main(string[] args)
        {
            // crea e inicializa primerArreglo
            int[] primerArreglo = { 1, 2, 3 };
            // copia la referencia en la variable primerArreglo
            int[] copiaPrimerArreglo = primerArreglo;
            Console.WriteLine(
            "Prueba: paso de la referencia a primerArreglo por valor");

            Console.Write("\nContenido de primerArreglo" +
            "antes de 11amar a PrimerDoble: \n\t");
// imprime el contenido de primerArreglo
    for (int i = 0; i < primerArreglo.Length; i++)
                Console.Write("{0}", primerArreglo[i]);
            // pasa la variable primerArreglo por valor a PrimerDoble
            PrimerDoble(primerArreglo);
            Console.Write("\n\nContenido de primerArreglo después de " +
            "Tamar a PrimerDoble\n\t");
            // imprime el contenido de primerArreglo
            for (int i = 0; i < primerArreglo.Length; i++)
                Console.Write("{0}", primerArreglo[i]);
            // prueba si PrimerDoble cambió la referencia
            if ( primerArreglo == copiaPrimerArreglo )
            Console.WriteLine("\n\nLas referencias son al mismo arreglo");
    else
                Console.WriteLine(
"\n\nLas referencias son a distintos arreglos");
// crea e inicializa segundoArreglo
int[] segundoArreglo = { 1, 2, 3 };
            // copia la referencia en la variable segundoArreglo
            int[] copiaSegundoArreglo = segundoArreglo;
            Console.WriteLine("\nPrueba: paso de la referencia a segundoArreglo " +
    "por referencia");
            Console.Write("\nContenido de segundoArreglo " +
            "antes de 11amar a SegundoDoble: \n\t");
            // imprime el contenido de segundoArreglo antes de la 11amada al método
            for (int i = 0; i < segundoArreglo.Length; i++)
                Console.Write("{0}", segundoArreglo[i]);
                // pasa la variable segundoArreglo por referencia a SegundoDoble
                SegundoDoble(ref segundoArreglo) ;
            Console.Write( "\n\nContenido de segundoArreglo " +
            "antes de llamar a SegundoDoble: \n\n");
            // imprime el contenido de segundoArreglo antes de la 11amada al método
            for (int i = 0; i < segundoArreglo.Length; i++)
                Console.Write("{0}", segundoArreglo[i]);
            // prueba si SegundoDoble cambió la referencia

            if (segundoArreglo == copiaSegundoArreglo)
                Console.WriteLine(
                "\n\nLas referencias son al mismo arreglo");
            else
                Console.WriteLine(
                "\n\nLas referencias son a distintos arreglos");

            
        }
        public static void PrimerDoble(int[] arreglo)
        {
            // duplica el valor de cada elemento
            for (int i = 0; i < arreglo.Length; i++)
                arreglo[i] *= 2;
            // crea nuevo objeto y asigna su referencia a arreglo
            arreglo = new int[] { 11, 12, 13 };
        } // fin del método PrimerDoble
          // modifica los elementos de arreglo y modifica la referencia al arreglo
          // para que haga referencia a un nuevo
        public static void SegundoDoble(ref int[] arreglo)
        {
            // duplica el valor de cada elemento
            for (int i = 0; i < arreglo.Length; i++)
                arreglo[i] *= 2;
            // crea nuevo objeto y asigna su referencia a arreglo
            arreglo = new int[] { 11, 12, 13 };
        }
    }
}

