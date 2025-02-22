using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models.Entities
{
    public class BMI
        {
            public float Weight { get; set; }  // Cân nặng (kg)
            public float Height { get; set; }  // Chiều cao (m)
            public float CS_BMI { get; set; }    // Chỉ số BMI
            public string Note { get; set; } // Trạng thái BMI (Thiếu cân, Bình thường, Thừa cân, Béo phì)
        }
}