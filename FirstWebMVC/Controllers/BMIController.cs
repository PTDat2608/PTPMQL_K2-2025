using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
using DemoMVC.Models.Entities;

namespace FirstWebMVC.Controllers;
public class BMIController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Tinh_BMI(BMI model)
    {
        if(model.Weight > 0 && model.Height > 0)
        {
            model.CS_BMI = model.Weight / (model.Height * model.Height); // Trọng lượng / chiều cao bình phương
            
            // Xác định trạng thái BMI 
            // BMI lý tưởng sẽ nằm trong khoảng từ 18,5 đến 24,9
            if (model.CS_BMI < 18.5)
                model.Note = "Thiếu cân";
            else if (model.CS_BMI >= 18.5 && model.CS_BMI < 24.9)
                model.Note = "Bình thường";
            else if (model.CS_BMI >= 25 && model.CS_BMI < 29.9)
                model.Note = "Thừa cân";
            else
                model.Note = "Béo phì";

            // Truyền kết quả BMI và trạng thái về View
            ViewBag.Tinh_BMI = model.CS_BMI;
            ViewBag.Note = model.Note;
        }
        else
        {
            ViewBag.Message = "Vui lòng nhập cân nặng và chiều cao hợp lệ!";
        }
        return View("Index");
    }
}