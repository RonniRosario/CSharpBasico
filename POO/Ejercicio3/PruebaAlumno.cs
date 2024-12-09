namespace Ejercicio3
{
    public class PruebaAlumno
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Juan", "32DFDSF", "Software", [100,100,65,90],0);
            Alumno alumno2 = new Alumno("Pedro", "3ASFA", "Software", [100, 100,78,98],0);
            Alumno alumno3 = new Alumno("Martin", "432DFDS", "Software", [97, 100,86],0);

            var promedio = alumno1.CalcularPromedio();
            alumno1.MostrarInformacion(promedio);

            var promedio2 = alumno2.CalcularPromedio();
            alumno2.MostrarInformacion(promedio2);

            var promedio3 = alumno3.CalcularPromedio();
            alumno3.MostrarInformacion(promedio3);

        }
    }
}
