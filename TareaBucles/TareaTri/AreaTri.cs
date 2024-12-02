using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaTri
{
    internal class AreaTri
    {

        public void CalcularTri()
        {
            double baseTriangulo = 0;
            double altura = 0;
            string value = string.Empty;
            double areaTriangulo = 0;
            int cantidadTriangulos = 0;
            int areaLimite = 12;
            int excedeArea = 0;
            
            try
            {
              
                Console.WriteLine("Introduce cuantos triangulos se calcularan en este programa");
                value = Console.ReadLine();
                validacionInt(value, out cantidadTriangulos, "La cantidad de triangulos es necesaria");

                for (int i = 1; i <= cantidadTriangulos; i++)
                {
                    Console.WriteLine($"Introduce la altura del triangulo {i}");
                    value = Console.ReadLine();
                    validacionDouble(value, out altura, "La altura de los triangulos es necesaria");

                    Console.WriteLine($"Introduce la base del triangulo {i}");
                    value = Console.ReadLine();
                    validacionDouble(value, out baseTriangulo, "La base de los triangulos es necesaria");

                    areaTriangulo = (baseTriangulo * altura) / 2;
                    Console.WriteLine($"Base del triangulo {baseTriangulo}\nAltura del triangulo {altura}\nArea del triangulo {areaTriangulo}");

                    if (areaTriangulo > areaLimite)
                    {
                        excedeArea++;
                    }

                }

                Console.WriteLine($"Triangulos que exceden el valor limite {excedeArea}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en el calculo de area de los triangulos {ex.Message}");

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
    }
}

