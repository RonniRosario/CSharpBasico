namespace programaTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            nivelPostulante();
        }

        private static void nivelPostulante()
        {
            string nombrePostulante = "";
            double totalPreguntas = 0;
            double respuestasCorrectas = 0;
            double nivelPostulante = 0;

            Console.WriteLine("Ingrese el nombre del postulante");

            nombrePostulante = Console.ReadLine();

            if (string.IsNullOrEmpty(nombrePostulante))
            {
                Console.WriteLine("Debes ingresar un nombre");
                return;
            }

            Console.WriteLine("Ingrese el numero de preguntas");
            if (!double.TryParse(Console.ReadLine(), out totalPreguntas))
            {
                Console.WriteLine("Debes ingresar un numero");
            }

            Console.WriteLine("Ingrese el numero de respuestas correctas");
            if (!double.TryParse(Console.ReadLine(), out respuestasCorrectas))
            {
                Console.WriteLine("Debes ingresar un numero");
            }


            nivelPostulante = (respuestasCorrectas / totalPreguntas) * 100;

            if (nivelPostulante >= 90)
            {
                Console.WriteLine($"Felicidades, este es tu porcentaje de acierto: {nivelPostulante}, estas en el nivel maximo");
            }
            else if (nivelPostulante >= 75)
            {
                Console.WriteLine($"Felicidades, este es tu porcentaje de acierto: {nivelPostulante}, estas en el nivel medio");
            }
            else if (nivelPostulante >= 50)
            {
                Console.WriteLine($"Felicidades, este es tu porcentaje de acierto: {nivelPostulante}, estas en el nivel regular");
            }
            else
            {
                Console.WriteLine($"Lo sentimos, este es tu porcentaje de acierto: { nivelPostulante}, estas fuera de nivel");
            }
        }
    }
}