﻿

namespace TareaArray
{
    internal class MatrizElementos
    {


        /// <summary>
        /// Escribe un programa que cree una matriz de 20 elementos de tipo entero e inicialice cada uno de los elementos con un valor igual al índice del elemento multiplicado por 5. Imprime los elementos en la consola.
        /// </summary>
        public void IndiceMult5()
        {

            int[] MatrizMult = new int[20];
            for (int i = 0; i < MatrizMult.Length; i++)

            {
                MatrizMult[i]= i * 5;
                Console.WriteLine(MatrizMult[i]);
            }
        }
    }
}
