using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Shop.DAL.Models.Employees
{
    public class EmployeesCreateOrUpdateModel
    {
        [Key]
        public int? empid { get { return this.Id; } }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public string title { get; set; }
        public string titleofcourtesy { get; set; }
        public DateTime birthdate { get; set; }
        public DateTime hiredate { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string address { get; set; }
        public int? UserId { get; set; }
        public DateTime? ChangeDate { get; set; }
        public int? Id { get; set; }
    }
}
