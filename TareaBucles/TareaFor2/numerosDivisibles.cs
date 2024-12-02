
namespace TareaFor2
{
    internal class numerosDivisibles
    {
        /// <summary>
        /// Crear un programa que cuente cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.
        /// </summary>
        public void numerosDiv()
        {
            int numerosIntroducir = 0;
            int numerosDivisibles = 0;
            int numerosNoDivisibles = 0;
            int numeros = 0;
            string value = string.Empty;
            
           
            try
            {
                Console.WriteLine("Introduce cuantos numeros trabajaremos");
                value = Console.ReadLine();
                validacionInt(value, out numerosIntroducir, "el valor introducido es incorrecto");

                for (int i = 1; i <= numerosIntroducir; i++)
                {
                    Console.WriteLine($"Introduce el valor del numero {i}");
                    value = Console.ReadLine();
                    validacionInt(value, out numeros, "recuerda que debes introducir un numero");


                    if(numeros %3 == 0 || numeros %5 ==0)
                    {
                        numerosDivisibles++;
                    }
                    else
                    {
                        numerosNoDivisibles++;
                    }
                }

                Console.WriteLine($"La cantidad de numeros divisibles son: {numerosDivisibles}\nLa cantidad de numeros no divisibles son: {numerosNoDivisibles}");


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
