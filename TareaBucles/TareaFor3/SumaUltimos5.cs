

namespace TareaFor3
{
    internal class SumaUltimos5
    {
        /// <summary>
        ///Desarrollar un programa que permita ingresar 10 números y luego muestre la suma de los últimos 5 números ingresados.
        /// </summary>
        public void Ultimos5Numeros()
        {
            int valorIntroducido = 0;  
            int numeros = 0;
            int acumulador = 0;
            string value = string.Empty;

            try
            {
                Console.WriteLine("Introduce cuantos numeros ingresaremos");
                value = Console.ReadLine();
                validacionInt(value, out valorIntroducido, "Debes ingresar un numero entero");

                for (int i = 1; i <= valorIntroducido; i++)
                {
                    Console.WriteLine($"Introduce el valor del numero {i}");
                    value = Console.ReadLine();
                    validacionInt(value, out numeros, "Debes ingresar un numero entero");

                    if (i > 5)
                    {
                        acumulador += numeros;
                    }

                }
                Console.WriteLine($"Suma de los ultimos 5 numeros {acumulador}");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error en el proceso de los numeros {ex.Message}");
            }

            
        }
        public void validacionInt(string valor, out int variableAsignada, string message)
        {
            if (!int.TryParse(valor, out variableAsignada))
            {
                Console.WriteLine($"{message}");
                throw new ArgumentException("Valor invalido");
            }
        }
    }
}
