
namespace Shop.DAL.Base
{
    public class PersonalInformation : AuditEntity
    {
        public string phone { get; set; }
        public string country { get; set; }
        public string? region { get; set; }
        public string? postalcode { get; set; }
        public string city { get; set; }
        public string address { get; set; }

    }
}
