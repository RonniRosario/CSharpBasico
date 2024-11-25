using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaArray
{
    internal class FabricaHierro
    {

        public void procesarPiezas()
        {
            int i = 1;
            int piezasAptas = 0;
            int piezasNoAptas = 0;
            int valorIntroducido = 0;
            double largoPieza = 0;
            string value = string.Empty;
            double[] aptas= new double[100];
            double[] noAptas = new double[100];
           


            try
            {
                Console.WriteLine("Introduce la cantidad de piezas que se comprobara su longitud");
                value = Console.ReadLine();

                validacionInt(value, out valorIntroducido, "La cantidad de piezas es necesaria");

                menorQue0(valorIntroducido, "El valor tiene que ser mayor que 0");

                while (i <= valorIntroducido)
                {
                    Console.WriteLine($"Ingrese la longitud de la pieza {i} ");
                    value = Console.ReadLine();

                    validacionDouble(value, out largoPieza, "La longitud de las piezas es necesaria");

                    menorQue0(Convert.ToInt16(largoPieza), "El largo introducido de la pieza debe ser mayor que 0");

                    if (largoPieza >= 1.20 && largoPieza <= 1.30)
                    {
                        
                        aptas[piezasAptas] = largoPieza;
                        piezasAptas++;
                    }
                    else
                    {
                      
                        noAptas[piezasNoAptas] = largoPieza;
                        piezasNoAptas++;

                    }

                    i++;

                }
                Console.WriteLine($"Cantidad de piezas procesadas {valorIntroducido}\nCantidad de piezas aptas {piezasAptas}\nCantidad de piezas no aptas {piezasNoAptas}");



                for (int n = 0; n < piezasAptas; n++)
                {
                    Console.WriteLine(aptas[n]);
                }

                for (int j = 0; j < piezasNoAptas; j++)
                {
                    Console.WriteLine(noAptas[j]);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine($" Error validando la longitud de las piezas {ex.Message}");
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

        public void validacionDouble(string valor, out double variableAsignada, string message)
        {
            if (!double.TryParse(valor, out variableAsignada))
            {
                Console.WriteLine($"{message}");
                throw new ArgumentException("Valor invalido");
            }
        }

        public void menorQue0(int variableAsignada,string message)
        {
            if (variableAsignada <= 0)
            {
                
                throw new ArgumentException($"{message}");
            }

        }
        }
    }
   

