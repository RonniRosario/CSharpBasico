internal class Program
{
    private static void Main(string[] args)
    {
        calcularNumeros();
    }
    private static void calcularNumeros() 
    {
    
        //Declarar variables 
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;
        int num4 = 0;
        int suma = 0;
        int producto = 0;

        // Pedir los numeros por teclado
        Console.WriteLine("Escriba el valor del numero 1");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el valor del numero 2");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el valor del numero 3");
        num3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba el valor del numero 4");
        num4 = Convert.ToInt32(Console.ReadLine());

        // Hacer la suma de los primeros dos y el producto de los 2 restantes

        suma = num1 + num2;
        producto = num3 * num4;


        Console.WriteLine($"La suma de los primeros dos numeros es { suma } y el producto de los ultimos dos numeros es {producto}");
        

    }
}
