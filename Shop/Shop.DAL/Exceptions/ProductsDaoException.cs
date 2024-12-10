
namespace Shop.DAL.Exceptions
{
    public class ProductsDaoException : Exception
    {
        public ProductsDaoException(string message) : base(message)
        {
            //Persistir el error
        }

    }
}
