internal class Program
{
    private static void Main(string[] args)
    {
        determinarSiEsMayor();
    }

    private static void determinarSiEsMayor()
    {
        double num1 = 0;
        double num2 = 0;
        double resultadoSuma = 0;
        double resultadoResta = 0;
        double resultadoMult = 0;
        double resultadoDiv = 0;


        Console.WriteLine("Escriba el primer numero");
        if (!double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Debes ingresar un entero");
            return;
        }

        Console.WriteLine("Escriba el segundo numero");
        if (!double.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Debes ingresar un entero");
            return;
        }

        if (num1 > num2)
        {
            resultadoSuma = (num1 + num2);
            resultadoResta = num1 - num2;

            Console.WriteLine($"El numero {num1} es mayor, esta es su suma {resultadoSuma} y esta es su resta {resultadoResta}");
        }
        else
        {
            resultadoMult = num2 * num1;
            resultadoDiv = num2 / num1;

            Console.WriteLine($"El numero {num2} es mayor, esta es su multiplicacion {resultadoMult} y esta es su division {resultadoDiv}");

        }
    }
}