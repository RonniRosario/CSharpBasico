using Shop.DAL.Base;

namespace Shop.DAL.Entities
{
    public class Customer : Company
    {
        public int custid { get; set; }
        public string email { get; set; }
    }
}
