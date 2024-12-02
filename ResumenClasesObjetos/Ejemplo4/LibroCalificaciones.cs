namespace Ejemplo4
{

    // Fig. 4.12: LibroCalificaciones.cs
    // La clase LibroCalificaciones con un constructor para inicializar el nombre del curso. 
    using System;
    public class LibroCalificaciones
    {
        private string nombreCurso; // nombre del curso para este LibroCalificaciones
                                    // el constructor inicializa nombre Curso con el objeto string suministrado como argumento
        public LibroCalificaciones(string nombre)
        {
            NombreCurso = nombre; // inicializa nombreCurso usando la propiedad 
        } // fin del constructor
          // propiedad para obtener (get) y establecer (set) el nombre del curso 
        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            } // fin de get
            set
            {
                nombreCurso = value;
            } // fin de set
        } // fin de la propiedad NombreCurso
          // muestra un mensaje de bienvenida para el usuario del LibroCalificaciones 
        public void MostrarMensaje()
        {
            // usa la propiedad Nombre Curso para obtener el
            // nombre del curso que representa este LibroCalificaciones
            Console.WriteLine("Bienvenido al libro de calificaciones para\n{0}!",
            NombreCurso);
        } // fin del método MostrarMensaje
    } // fin de la clase LibroCalificaciones
}
