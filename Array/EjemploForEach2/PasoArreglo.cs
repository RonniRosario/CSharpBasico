﻿namespace EjemploForEach2
{
    internal class PasoArreglo
    {
        //Main crea arreglo y llama a ModificarArreglo y ModificarElemento
        public static void Main(string[] args)
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Efectos de pasar una referencia a todo un arreglo:\n" +
                "Los valores del arreglo original son:");

            //imprime en pantalla elementos del arreglo original
            foreach (int valor in arreglo)
                Console.WriteLine("    {0}", valor);

            ModificarArreglo(arreglo); //pasa referencia al arreglo
            Console.WriteLine("\n\nLos valores del arreglo modificado son:");

            //imprime en pantalla elementos modificados del arreglo 
            foreach (int valor in arreglo)
                Console.WriteLine("    {0}", valor);

            Console.WriteLine(
                "Efectos de pasar el valor de un elemento del arreglo:\n" +
                "arreglo[3] antes de ModificarElemento: {0}", arreglo[3]);

            ModificarElemento(arreglo[3]); //trata de modificar arreglo [3]

            Console.WriteLine(
                "arreglo[3] después de ModificarElemento: {0}", arreglo[3]);
        }

        public static void ModificarArreglo(int[] arreglo2)
        {

            for (int contador = 0; contador < arreglo2.Length; contador++)
                arreglo2[contador] *= 2;
        }
        public static void ModificarElemento(int elemento)
        {
            elemento *= 2;
            Console.WriteLine(
            "Valor del elemento en ModificarElemento: {0}", elemento);
        }

    }
}
