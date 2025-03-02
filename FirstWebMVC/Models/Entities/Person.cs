using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models.Entities
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public String PersonID { get; set;}
        public String HoTen { get;set;}
        public String QueQuan { get; set;}
    }
}