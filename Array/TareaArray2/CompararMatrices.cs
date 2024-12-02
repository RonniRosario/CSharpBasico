

namespace TareaArray2
{
    internal class CompararMatrices
    {
        int[] matriz1;
        int[] matriz2;
        string value = string.Empty;
        int indiceMatriz = 0;
        int valorMatriz = 0;


        public void ComparacionMatrices(int[]matriz1, int[] matriz2)
        {

            try
            {
                if(matriz1.Length != matriz2.Length)
                {
                    Console.WriteLine("Las matrices no son iguales en longitud");
                    return;

                }
               
                    Console.WriteLine("Las matrices son iguales en longitud");
              

                for (int i = 0; i < matriz1.Length; i++)
                {
                    if (matriz1[i] != matriz2[i])
                    {
                        Console.WriteLine("Las matrices no tienen los mismos valores");
                        return;
                    }
                    
                }
                Console.WriteLine("Las matrices tienen los mismos valores");
            } 
            catch (Exception ex)
            {

                Console.WriteLine($"Error en la comparacion de matrices {ex.Message}");
            }
           
        }
       public int[] ImprimirMatriz1()
        {
            try
            {
                Console.WriteLine("Introduce la longitud de elementos de la matriz 1");
                value = Console.ReadLine();
                validacionInt(value, out indiceMatriz, "Debes asignar un numero entero");

                matriz1 = new int[indiceMatriz];

                for (int i = 0; i < matriz1.Length; i++)
                {
                    Console.WriteLine($"Introduzca el valor {i + 1} de la matriz");
                    value = Console.ReadLine();
                    validacionInt(value, out valorMatriz, "Debes asignar un numero entero");

                    matriz1[i] = valorMatriz;
                }

                Console.WriteLine("Matriz #1");
                foreach (int item in matriz1)
                {
                    Console.WriteLine(item);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error trabajando con la matriz 1 {ex.Message}");
            }
            return matriz1;
        }

        public int[] ImprimirMatriz2()
        {

            try
            {
                Console.WriteLine("Introduce la longitud de elementos de la matriz 2");
                value = Console.ReadLine();
                validacionInt(value, out indiceMatriz, "Debes asignar un numero entero");

                matriz2 = new int[indiceMatriz];

                for (int i = 0; i < matriz2.Length; i++)
                {
                    Console.WriteLine($"Introduzca el valor {i + 1} de la matriz");
                    value = Console.ReadLine();
                    validacionInt(value, out valorMatriz, "Debes asignar un numero entero");

                    matriz2[i] = valorMatriz;
                }

                Console.WriteLine("Matriz #2");
                foreach (int item in matriz2)
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"Error trabajando con la matriz 2 {ex.Message}");
            }
            return matriz2;

        }


        public void validacionInt(string valor, out int variableAsignada, string message)
        {
            if (!int.TryParse(valor, out variableAsignada))
            {
                Console.WriteLine($"{message}");
                throw new ArgumentException("Valor invalido");
            }
        }
    }
}
