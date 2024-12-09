
namespace Ejercicio2
{
    public class Libro
    {
        private string _titulo;
        private string _autor;
        private int _paginas;

        public Libro(string titulo, string autor, int paginas)
        {

            IsEmpty(titulo, "Debes introducir el titulo del libro");
            IsEmpty(autor, "Debes introducir el autor del libro");
            BiggerThan0(paginas, "Las paginas tienen que ser mayor a 0");
            _titulo = titulo;
            _autor = autor;
            _paginas = paginas;

        }

        public string titulo
        {
            get
            {
                return _titulo;
            }

            set
            {
                IsEmpty(value, "Debes introducir el titulo del libro");
                _titulo = value;
            }
        }

        public string autor
        {
            get
            {
                return _autor;
            }

            set
            {
                IsEmpty(value, "Debes introducir el autor del libro");
                _autor = value;
            }
        }

        public int paginas
        {
            get
            {
                return _paginas;
            }

            set
            {
                BiggerThan0(value, "Las paginas tienen que ser mayor a 0");
                _paginas = value;
            }
        }


        public void MostrarInformacion()
        {
            Console.WriteLine("Informacion del libro");

            Console.WriteLine($"Nombre del libro: {titulo}\nAutor del libro: {autor} \nPaginas del libro: {paginas}");

            Console.WriteLine($"Es largo el libro? {EsLargo()}");
        }

        public void IsEmpty(string variable, string message)
        {
            if (string.IsNullOrWhiteSpace(variable))
            {
                throw new ArgumentException($"{message}");
               
            }
           
        }

        public void BiggerThan0(int variable, string message)
        {
            if  (variable< 0)
            {
                throw new ArgumentException($"{message}");
            }
        }

        public bool EsLargo()
        {
            if (paginas > 500)
            {
               
                return true;
            }
            else
            {
                return false;
            }
        }
        }
    }

