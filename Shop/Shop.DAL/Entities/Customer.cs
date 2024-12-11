using Shop.DAL.Base;
using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.Entities
{
    public class Customer : Company
    {
        [Key]
        public int? custid { get; set; }
        public string email { get; set; }
    }
}
