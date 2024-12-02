

namespace CasoEstudio1
{
    public class PaqueteDeCartas
    {
        private Carta[] paquete;
        private int cartaActual;
        private const int NUMERO_DE_CARTAS=52;
        private Random numerosAleatorios;


        //el constructor llena el paquete de objetos Carta
        public PaqueteDeCartas()
        {
            string[] caras = { "As", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Joto", "Quiña", "Rey"};

            string[] palos = { "Corazones", "Diamantes", "Treboles", "Espadas" };

            paquete = new Carta[NUMERO_DE_CARTAS];
            cartaActual = 0;
            numerosAleatorios = new Random();

            //llena el paquete con objetos carta

            for(int cuenta = 0; cuenta < paquete.Length; cuenta++)
            {
                paquete[cuenta] =
                  new Carta (caras[cuenta % 13], palos[cuenta / 13]);
            }
        }

        public void Barajar()
        {
            cartaActual = 0;

            //para cada carta, selecciona otra carta aleatoria y las intercambia

            for(int primera = 0; primera<paquete.Length; primera++)
            {

                int segunda = numerosAleatorios.Next(NUMERO_DE_CARTAS);

                Carta temp = paquete[primera];
                paquete[primera] = paquete[segunda];
                paquete[segunda] = temp;
            }
        }

        public Carta RepartirCarta()
        {
            if(cartaActual < paquete.Length)
            {
                return paquete[cartaActual++];
            }
            else
            {
                return null;
            }
            
        }

    }
}
