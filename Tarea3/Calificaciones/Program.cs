

namespace Calificaciones
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            promedioCalificaciones();
        }
        private static void promedioCalificaciones()
        {
            //Declaracion de variables
            int nota = 0;
            int promedio = 0;
            int aprobados = 0;
            int reprobados = 0;
            int cantidadNota = 0;
            string valor = string.Empty;


            Console.WriteLine("Escriba la cantidad de notas que desea");
            valor = Console.ReadLine();
           
            //validar que la variable cantidadNota tenga un valor entero
            if(int.TryParse(valor, out cantidadNota))
            {
                for(int i = 1; i <= cantidadNota; i++)
                {
                    Console.WriteLine($"Escriba la nota {i}");
                    valor = Console.ReadLine();

                    if (int.TryParse(valor, out nota))
                    {
                        promedio += nota;

                        if(nota >= 7)
                        {
                            aprobados++;
                        }
                        else
                        {
                            reprobados++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("El valor que introduciste en la nota no es valido");
                    }
                }

                promedio /= cantidadNota;

                if(promedio >= 7)
                {
                    Console.WriteLine($"Fuiste promovido, tu promedio es {promedio}");
                }
                else
                {
                    Console.WriteLine($"Fuiste reprobado, tu promedio es {promedio}");
                }

                Console.WriteLine($"Las notas aprobadas son {aprobados} y reprobados son {reprobados}");
               
            }
            else
            {
                Console.WriteLine("El valor introducido no es valido");
            }

        }

    }
}

