using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudioPolimorfismo
{
    public class EmpleadoAsalariado : Empleado
    {
        private decimal salarioSemanal;

        public EmpleadoAsalariado(string nombre, string apellido, string nss, decimal salario) : base(nombre,apellido,nss)
        {
            salarioSemanal = salario;
        }

        public decimal SalarioSemanal
        {
            get
            {
                return salarioSemanal;
            }
            set
            {
                salarioSemanal = ((value >=0)? value : 0);
            }
        }

        public override decimal Ingresos()
        {
            return salarioSemanal;
        }

        public override string ToString()
        {
            return string.Format("empleado asalariado: {0}\n{1}: {2:C}",
                base.ToString(), "salario semanal", SalarioSemanal);
        }

    }
}
