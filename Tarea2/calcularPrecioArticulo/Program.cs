internal class Program
{
    private static void Main(string[] args)
    {
        calcularArticulo();  
    }

    private static void calcularArticulo()
    {

        //Declaracion de variables 
        string clientName = "";
        string article = "";
        int articlePrice = 0;
        int quantity = 0;
        int totalPrice = 0;

        //Pedir los datos por consola 

        Console.WriteLine("Introduzca su nombre");
        clientName = Console.ReadLine();

        Console.WriteLine("Introduzca el nombre del articulo que desea comprar:");
        article = Console.ReadLine();

        Console.WriteLine("Introduzca el precio del articulo");
        articlePrice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduzca la cantidad que desea");
        quantity = Convert.ToInt32(Console.ReadLine());

        totalPrice = quantity * articlePrice;


        Console.WriteLine($"Su nombre es: {clientName}");
        Console.WriteLine($"Su articulo es: {article}");
        Console.WriteLine($"El precio del articulo es: {articlePrice}");
        Console.WriteLine($"La cantidad del articulo es: {quantity}");
        Console.WriteLine($"El total que debera abonar es:{totalPrice} ");



    }
}