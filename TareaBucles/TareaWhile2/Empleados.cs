using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaWhile2
{
    internal class Empleados
    {
        public void sueldoEmpleados()
        {
            int i = 1;
            int cantidadEmpleados = 0;
            double acumulador = 0;
            double salario = 0; 
            string value = string.Empty;
            int salarioMinimo = 0;
            int salarioMaximo = 0;

            Console.WriteLine("Introduce cuantos empleados procesaremos");
            value = Console.ReadLine();
            validacionInt(value, out cantidadEmpleados, "El valor introducido es incorrecto");

            while (i<= cantidadEmpleados)
            {
                Console.WriteLine($"Introduce el salario del empleado {i} (100-500)");
                value = Console.ReadLine();
                validacionDouble(value, out salario, "El salario introducido es incorrecto");

                if(salario >=100 && salario <= 300)
                {
                    salarioMinimo ++;
                }
                else if (salario >300)
                {
                    salarioMaximo ++;
                }

                acumulador += salario;
                i++;
            }
            Console.WriteLine($"Empleados procesados {cantidadEmpleados}\nEmpleados en el primer rango (100-300) {salarioMinimo}\nEmpleados en el segundo rango (>300) {salarioMaximo}\nTotal a gastar en nomina {acumulador}");

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
