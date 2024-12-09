using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Alumno
    {
        private string _nombre;
        private string _matricula;
        private string _carrera;
        private double _promedio;
        private List <int> _calificaciones = new List <int>();

        public Alumno(string nombre, string matricula, string carrera, List<int> calificacion, double promedio)
        {
            IsEmpty(nombre, "El nombre es requerido");
            IsEmpty(matricula,"La matricula es requerida");
            IsEmpty(carrera, "La carrera es requerida");
            RangoPromedio(promedio,"El promedio no puede ser mayor a 100 o menor que 0");
            _nombre = nombre;
            _matricula = matricula;
            _carrera = carrera;
            _calificaciones =calificacion;
            _promedio = promedio;
        }

        public string nombre
        {
            get { return _nombre; }

            set
            {
                IsEmpty(nombre, "El nombre es requerido");
                _nombre = value;
            }
        }

        public string matricula
        {
            get { return _matricula; }

            set
            {
                IsEmpty(matricula, "La matricula es requerida");
                _matricula = value;
            }
        }

        public string carrera
        {
            get { return _carrera; }

            set
            {
                IsEmpty(carrera, "La matricula es requerida");
                _carrera = value;
            }
        }

        public List<int> calificaciones
        {
            get { return _calificaciones; }

            set
            {
                _calificaciones = value;
            }
        }

        public double promedio
        {
            get { return _promedio; }

            set
            {
                RangoPromedio(promedio,"El promedio no puede ser mayor a 100 o menor que 0");
                _promedio = value;
            }
        }

        public double CalcularPromedio()
        {
            
            double notas=0;
            for (int i = 0; i <_calificaciones.Count; i++)
            {
                notas += _calificaciones[i];
                _promedio = (notas) / _calificaciones.Count;
            }
            
            return _promedio;
        }
        public void MostrarInformacion(double promedio)
        {
            Console.WriteLine($"Nombre del estudiante:{nombre}" +
                $"\nMatricula del estudiante:{matricula}" +
                $"\nCarrera del estudiante:{carrera}\n" +
                $"Promedio del estudiante:{promedio}");

            Console.WriteLine("Notas del estudiante");

            foreach (var item in calificaciones)
            {
                Console.WriteLine(item+" ");
            }
            Console.WriteLine();
            
        }

        public void IsEmpty(string variable, string message)
        {
            if (string.IsNullOrWhiteSpace(variable))
            {
                throw new ArgumentException($"{message}");
               
            }
           
        }

        public void RangoPromedio(double variable, string message)
        {
            if(variable>100 || variable< 0)
            {
                throw new ArgumentException(message);
            }

        }

    }
}
