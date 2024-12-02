using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio3
{
    public class LibroCalificaciones
    {
        private string nombreCurso;
        private int[,] calificaciones;

        public LibroCalificaciones(string nombre, int[,] arregloCalificaciones)
        {
            nombreCurso = nombre;
            calificaciones = arregloCalificaciones;
        }

        public string NombreCurso
        {
            get
            {
                return nombreCurso;
            }
            set
            {
                nombreCurso = value;
            }

        }

        public void MostrarMensaje()
        {
            Console.WriteLine("!Bienvenido al libro de calificaciones para \n{0}!\n", nombreCurso);
        }

        public void ProcesarCalificaciones()
        {
            ImprimirCalificaciones();

            Console.WriteLine("\n{0} {1}\n{2} {3}\n",
                "La calificacion mas baja en el libro de calificaciones es", ObtenerMinima(),
                "La calificacion mas alta en el libro de calificaciones es", ObtenerMaxima());

            ImprimirGraficoBarras();
        }

        public int ObtenerMinima()
        {
            int califBaja = calificaciones[0, 0];

            foreach (int calificacion in calificaciones)
            {
                if (calificacion < califBaja)
                    califBaja = calificacion;
            }
            return califBaja;
        }

        public int ObtenerMaxima()
        {
            int califAlta = calificaciones[0, 0];

            foreach (int calificacion in calificaciones)
            {
                if (calificacion > califAlta)
                    califAlta = calificacion;
            }
            return califAlta;
        }

        public double ObtenerPromedio(int estudiante)
        {
            int monto = calificaciones.GetLength(1);
            int total = 0;

            for (int examen = 0; examen < monto; examen++)
            {
                total += calificaciones[estudiante, examen];
            }

            return (double)total / monto;
        }

        public void ImprimirGraficoBarras()
        {
            int[] frecuencia = new int[11];

            foreach (int calificacion in calificaciones)
            {
                ++frecuencia[calificacion / 10];
            }

            for (int cuenta = 0; cuenta < frecuencia.Length; cuenta++)
            {
                if (cuenta == 10)
                {
                    Console.Write("   100:  ");
                }
                else
                {
                    Console.Write("{0:D2}-{1:D2}: ",
                        cuenta * 10, cuenta * 10 + 9);
                }

                for (int estrellas = 0; estrellas < frecuencia[cuenta]; estrellas++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public void ImprimirCalificaciones()
        {
            Console.WriteLine("Las calificaciones son:\n");
            Console.Write("            ");

            for (int prueba = 0; prueba < calificaciones.GetLength(1); prueba++)
            {
                Console.Write("Prueba {0}", prueba +1);
            }

            Console.WriteLine("Promedio");

            for(int estudiante = 0; estudiante<calificaciones.GetLength(0); estudiante++)
            {
                Console.Write("Estudiante {0,2}", estudiante + 1);

                for(int calificacion = 0; calificacion <calificaciones.GetLength(1); calificacion++)
                {
                    Console.Write("{0,8}", calificaciones[estudiante, calificacion]);
                }


            Console.WriteLine("{0,9:F2}",ObtenerPromedio(estudiante));
            }
        }
    }
}
