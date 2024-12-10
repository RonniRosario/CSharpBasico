

using Shop.DAL.Base;

namespace Shop.DAL.Entities
{
    public class Employees : PersonalInformation
    {
        public int empid { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string title { get; set; }
        public string titleofcourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }


    }
}
