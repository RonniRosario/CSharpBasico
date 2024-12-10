using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DAL.Models.Products
{
    public class ProductsCreateOrUpdateModel
    {
        public int? productid { get; set; }
        public string productname { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public bool discontinued { get; set; }
        public int? UserId { get; set; }
        public DateTime? ChangeDate { get; set; }
    }
}
