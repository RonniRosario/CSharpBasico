using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaClases;

namespace Ejemplo1
{
    // Fig. 4.2: PruebaLibroCalificaciones.cs
    // Crea un objeto LibroCalificaciones y llama a su método MostrarMensaje.
    public class PruebaLibroCalificaciones
    {
        // El método Main comienza la ejecución del programa
        public static void Main(string[] args)
        {
            // crea un objeto LibroCalificaciones y lo asigna a miLibroCalificaciones 
            LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones();
            // 11ama al método MostrarMensaje de miLibroCalificaciones
            miLibroCalificaciones.MostrarMensaje();
        } // fin de Main
    } // fin de la clase PruebaLibroCalificaciones
}
