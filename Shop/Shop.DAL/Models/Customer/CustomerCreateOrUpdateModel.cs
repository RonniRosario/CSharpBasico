

namespace Shop.DAL.Models.Customer
{
    public class CustomerCreateOrUpdateModel
    {
        public int? custid { get { return this.Id; } }
        public string email { get; set; }
        public string companyname { get; set; }
        public string contactname { get; set; }
        public string contacttitle { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public int? UserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? Id { get; set; }
    }
}
