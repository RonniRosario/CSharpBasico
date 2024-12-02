

namespace TareaWhile
{
    internal class Calificaciones
    {
        public void calificacionEstudiante()
        {
            int i = 1;
            int cantidadCalificaciones = 0;
            double calificaciones = 0;
            int estudiantesAprobados = 0;
            int estudiantesReprobados = 0;
            string value = string.Empty;

            try
            {
                Console.WriteLine("Escribe cuantas calificaciones trabajaremos");
                value = Console.ReadLine();
                validacionInt(value, out cantidadCalificaciones, "El valor introducido es incorrecto");
                while (i<=cantidadCalificaciones)
                {
                    Console.WriteLine($"Escribe la calificacion del estudiante {i}");
                    value = Console.ReadLine();
                    validacionDouble(value, out calificaciones, "La calificacion que asignaste es incorrecta");

                    if (calificaciones>=7)
                    {
                        estudiantesAprobados++;
                    }
                    else { 
                        estudiantesReprobados++;
                    }

                    i++;
                }
                Console.WriteLine($"Estudiantes aprobados {estudiantesAprobados}\nEstudiantes reprobados {estudiantesReprobados}");

            }

            catch (Exception ex)
            {
                Console.WriteLine ($"Error trabajando con las calificaciones de los estudiantes{ex.Message}");
              
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
