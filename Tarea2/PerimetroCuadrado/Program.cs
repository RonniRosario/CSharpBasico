internal class Program
{
    private static void Main(string[] args)
    {
        perimetroCuadrado();
    }

    private static void perimetroCuadrado()
    {
        //Declaracion de variables 
        int lado = 0;
        int perimetro = 0;

        Console.WriteLine("Introduzca un lado del cuadrado");
        lado = Convert.ToInt32(Console.ReadLine());

        perimetro = (lado * 4);

        Console.WriteLine($"El perimetro de su cuadrado es: {perimetro}");
    }
}