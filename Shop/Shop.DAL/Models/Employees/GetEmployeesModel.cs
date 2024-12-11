
using System.ComponentModel.DataAnnotations;

namespace Shop.DAL.Models.Employees
{
    public class GetEmployeesModel
    {
        [Key]
        public int? empid { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public DateTime? hiredate { get; set; }
        public DateTime? birthdate { get; set; }
        public string phone { get; set; }
        public string title { get; set; }
        public string titleofcourtesy { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
    }
}
