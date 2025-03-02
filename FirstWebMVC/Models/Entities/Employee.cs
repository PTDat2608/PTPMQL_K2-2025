using System.ComponentModel.DataAnnotations;
using FirstWebMVC.Models.Entities;

namespace FirstWebMVC.Models.Entities
{
    public class Employee : Person
    {
    public string EmployeeID { get; set; }
    public string Company { get; set; }
    }
}