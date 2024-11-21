using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {

        calcularSuma();
    }


    private static void calcularSuma()
    {
        // Declarar variables de entrada 
        int num1 = 0;
        int num2 = 0;
        int suma = 0;
        int producto = 0;

        // Pedir numeros por teclado

        Console.WriteLine("Escriba el valor del numero 1");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el valor del numero 2");
        num2 = Convert.ToInt32(Console.ReadLine());

        // Calcular la suma y el producto
        suma = (num1 + num2);
        producto = (num1 * num2);
        Console.WriteLine($"La suma de los dos numeros es {suma} y su producto es  {producto}");

    }
}