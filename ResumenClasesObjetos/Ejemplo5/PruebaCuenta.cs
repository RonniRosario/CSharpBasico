using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo5
{

    // Fig. 4.16: PruebaCuenta.cs
    // Creación y manipulación de un objeto Cuenta. using System;
    public class PruebaCuenta
    {
        // El método Main comienza la ejecución de la aplicación de C#

        public static void Main(string[] args) {
            Cuenta cuenta1 = new Cuenta (50.00M );
            Cuenta cuenta2 = new Cuenta(-7.53M);
            // crea el objeto Cuenta  // crea el objeto Cuenta
            // muestra el saldo inicial de cada objeto usando una propiedad 

            Console.WriteLine("Saldo de cuental: {0:C}", cuenta1.Saldo ); // muestra la propiedad Saldo 

            Console.WriteLine("Saldo de cuenta2: {0:C}\n", cuenta2.Saldo);
            // muestra la propiedad Saldo

            decimal montoDeposito; // deposita la cantidad que se leyó del usuario
                                   // pide y obtiene la entrada del usuario
            Console.Write("Escriba el monto a depositar para la cuenta1: "); montoDeposito = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("se sumó {0:C} al saldo de cuental\n",
            montoDeposito);
            cuenta1.Acredita(montoDeposito); // se suma al saldo de cuenta1


            // muestra los saldos
            Console.WriteLine("Saldo de cuenta1: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}\n", cuenta2.Saldo);
            // pide y obtiene la entrada del usuario
            Console.Write("Escriba la cantidad a depositar para la cuenta2: "); 
            montoDeposito = Convert.ToDecimal(Console.ReadLine() );
            Console.WriteLine("se sumó {0:C} al saldo de cuenta2\n", montoDeposito);
            cuenta2.Acredita(montoDeposito); // se suma al saldo de cuenta2
                                             // muestra los saldos
            Console.WriteLine("Saldo de cuental: {0:C}", cuenta1.Saldo);
            Console.WriteLine("Saldo de cuenta2: {0:C}", cuenta2.Saldo);
        }
    } }