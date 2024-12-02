using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoEstudio1
{
    public class Carta
    {
        private string cara; //cara de la carta ("As", "Dos", ...)
        private string palo; // palo de la carta ("Corazones", "Diamantes")

        //el constructor con dos parametros inicializa la cara y el palo de la carta 

        public Carta(string caraCarta, string paloCarta)
        {
            cara = caraCarta; //inicializa la cara de la carta
            palo = paloCarta; //inicializa el palo de la carta
        } //fin del constructor de Carta con dos parametros 

        //devuelve representacion de cadena del objeto carta
        public override string ToString()
        {
            return cara + " de " + palo;
        } //fin del metodo ToString

    }
}
