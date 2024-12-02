using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaArray3
{
    internal class EstructuraDatos
    {


        public void SolicitarNumeros()
        {

            try
            {
                int[] numerosASolicitar;
                int indiceMatriz = 0;
                int valorMatriz = 0;
                //int numeroRepetido = 0;

                string value = string.Empty;
                List<int> NumerosRepetidos = new List<int>();
                List<int> NumerosUnicos = new List<int>();




                Console.WriteLine("Introduce la cantidad de numeros a evaluar");
                value = Console.ReadLine();
                validacionInt(value, out indiceMatriz, "El numero debe de ser un entero");

                numerosASolicitar = new int[indiceMatriz];

                for (int i = 0; i < numerosASolicitar.Length; i++)
                {
                    Console.WriteLine($"Introduzca el numero {i + 1}");
                    value = Console.ReadLine();
                    validacionInt(value, out valorMatriz, "El valor que ingresaste fue incorrecto");
                    numerosASolicitar[i] = valorMatriz;


                    int indice = NumerosUnicos.IndexOf(valorMatriz);

                    if (indice >= 0)
                    {
                        NumerosRepetidos[indice]++;
                    }
                    else
                    {
                        NumerosUnicos.Add(valorMatriz);
                        NumerosRepetidos.Add(1);
                    }

                }
                Console.WriteLine("Numeros: ");
                foreach (var item in NumerosUnicos)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();


                for (int i = 0; i < NumerosUnicos.Count; i++)
                {
                    if (NumerosRepetidos[i] > 1)
                    {
                        Console.WriteLine($"El número {NumerosUnicos[i]} se repitió {NumerosRepetidos[i]} veces.");
                    }
                }

                int NumeroMenor = numerosASolicitar.Min();
                Console.WriteLine($"El numero menor fue {NumeroMenor}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error en el procesamiento de los numeros");
            }
           
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
