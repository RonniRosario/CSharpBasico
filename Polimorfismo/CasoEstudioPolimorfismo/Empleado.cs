namespace CasoEstudioPolimorfismo
{
    public abstract class Empleado
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;

        public Empleado(string nombre, string apellido, string nss)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
        }

        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }

        }

        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }
        }

        public string NumeroSeguroSocial
        {
            get
            {
                return numeroSeguroSocial;
            }
        }

        public override string ToString()
        {
            return string.Format( "{0} {1}\nnumero de seguro social: {2}", 
                PrimerNombre, ApellidoPaterno, NumeroSeguroSocial);
        }

        public abstract decimal Ingresos();
    }
}
