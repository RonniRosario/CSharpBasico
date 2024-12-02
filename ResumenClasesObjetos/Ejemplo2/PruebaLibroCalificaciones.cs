using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo2
{

    // Fig. 4.5: LibroPruebaCalificaciones.cs
    // Crea objeto LibroCalificaciones y pasa una cadena a // su método MostrarMensaje.
    using System;
    public class LibroPruebaCalificaciones
    {
        // El método Main comienza la ejecución del programa
        public static void Main(string[] args)
        {
            // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones 
            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();
            // pide el nombre del curso y lo recibe como entrada
            Console.WriteLine("Por favor escriba el nombre del curso:");
            string nombreDelCurso = Console.ReadLine(); // lee una línea de texto Console.WriteLine(); 
            // imprime en pantalla una línea en blanco
            // 11ama al método MostrarMensaje de miLibroCalificaciones  
            // y pasa nombreDelCurso como argumento
            miLibroCalificaciones.MostrarMensaje(nombreDelCurso);
        } // fin de Main
    } // fin de la clase LibroPruebaCalificaciones
}
