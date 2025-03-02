using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstWebMVC.Models.Entities
{
    public class Student
    {
       [Key]
        public string StudentID { get; set; }   
        public string Fullname { get; set;}
        public string Address { get; set;}
    }
}