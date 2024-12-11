

namespace Shop.DAL.Models.Products
{
    public class ProductsCreateOrUpdateModel
    {
        public int? productid { get { return this.Id; } }
        public string productname { get; set; }
        public int supplierid { get; set; }
        public int categoryid { get; set; }
        public decimal unitprice { get; set; }
        public bool discontinued { get; set; }
        public int? UserId { get; set; }
        public DateTime? ChangeDate { get; set; }

        public int Id { get; set; }
    }
}
