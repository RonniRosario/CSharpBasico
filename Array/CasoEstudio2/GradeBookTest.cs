namespace CasoEstudio2
{
    internal class GradeBookTest
    {
       public static void Main(string[] args)
        {
            int[] arregloCalificaciones = { 87, 68, 100, 83, 78, 85, 91, 76, 87 };

            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
                "CS101 Introduccion a la programacion en c#", arregloCalificaciones);
            miLibroCalificaciones.MostrarMensaje();
            miLibroCalificaciones.ProcesarCalificaciones();

        }
    }
}
