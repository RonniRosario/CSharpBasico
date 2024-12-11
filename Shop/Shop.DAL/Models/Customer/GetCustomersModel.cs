
namespace Shop.DAL.Models.Customer
{
    public class GetCustomersModel
    {
        public int? custid { get; set; }
        public string email { get; set; }
        public DateTime? creation_date { get; set; }
        public string companyname { get; set; }
        public string address { get; set; }
        public string country { get; set; }
        public string city { get; set; }
    }
}
