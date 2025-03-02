using System.ComponentModel.DataAnnotations;

namespace FirstWebMVC.Models.Entities
{
    public class HeThongPhanPhoi
    {
        [Key]
        public String MaHTPP { get; set;}
        public String TenHTPP { get;set;}
       
    }
}