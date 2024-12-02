namespace CasoEstudio3
{
    internal class PruebaLibroCalificaciones
    {
        public static void Main(string[] args)
        {
            int[,] arregloCalificaciones = { { 87,96,70},
                { 68,87,90},
                {94,100,90 },
                {100,81,82 },
                {83,65,85 },
                {78,87,65 },
            {85,73,83 },
            {91,94,100 },
            {76,72,84 },
            {87,93,73 } };

            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
                 "CS101 Introduccion a la programacion en c#", arregloCalificaciones);
            miLibroCalificaciones.MostrarMensaje();
            miLibroCalificaciones.ProcesarCalificaciones();


        }
    }
}
