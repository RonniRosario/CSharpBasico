

namespace TareaFor
{
    internal class Triangulo
    {
        /// <summary>
        /// Dado un conjunto de datos representando las dimensiones de triángulos, calcular y contar aquellos cuya área excede un valor límite.
        /// </summary>
        public void trianguloAreaLimite()
        {
            double baseTriangulo = 0;
            double altura = 0;
            string value = string.Empty;
            double areaTriangulo = 0;
            int cantidadTriangulos = 0;
            double areaLimite = 0;
            int excedeArea = 0;
            int dentroArea = 0;
     


            try
            {
                Console.WriteLine("Introduce el area limite de los triangulos");
                value = Console.ReadLine();
                validacionDouble(value, out areaLimite, "el area limite de triangulos es necesaria");
               
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
                    Console.WriteLine($"Area del triangulo {areaTriangulo}");

                    if(areaTriangulo <= areaLimite)
                    {
                        dentroArea++;
                    }
                    else
                    {
                        excedeArea++;
                    }

                }

                Console.WriteLine($"Triangulos que exceden el valor limite {excedeArea}\nTriangulos que estan dentro del valor limite {dentroArea}\n");

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
