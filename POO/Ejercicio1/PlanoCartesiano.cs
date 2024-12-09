using System.Security.Cryptography.X509Certificates;

namespace Ejercicio1
{
    public class PlanoCartesiano
    {
        private int _valorX;
        private int _valorY;

        public PlanoCartesiano(int valorx, int valorY)
        {
            _valorX = valorx;
            _valorY = valorY;

        }
        public int valorX
        {
            get
            {
                return _valorX;
            }

            set
            {
               
                _valorX = value;
            }
            
        }

        public int valorY
        {
            get
            {
                return _valorY;
            }

            set
            {
                _valorY = value;
            }

        }       

        public void ImprimirCuadrante()
        {

            ImprimirEje();

            if (valorX > 0 && valorY > 0)
            {
                Console.WriteLine("Estas en el primer cuadrante");
            }
            else if(valorX < 0 && valorY > 0)
            {
                Console.WriteLine("Estas en el segundo cuadrante");
            }
            else if (valorX < 0 && valorY < 0)
            {
                Console.WriteLine("Estas en el tercer cuadrante");
            }
            else
            {
                Console.WriteLine("Estas en el cuarto cuadrante");
            }
        }

        public void ImprimirEje()
        {
            Console.WriteLine($"Valor del eje x: {valorX}\nValor del eje Y: {valorY}");
        }

    }
}
