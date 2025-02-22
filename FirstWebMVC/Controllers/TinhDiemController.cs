using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
using FirstWebMVC.Models.Entities;

namespace FirstWebMVC.Controllers;
public class TinhDiemController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Tong_Diem(TinhDiem model)
    {
         // Giả sử tỉ lệ: A = 60%, B = 30%, C = 10%
        model.DiemTB = (model.DiemA * 0.6f) + (model.DiemB * 0.3f) + (model.DiemC * 0.1f);

        ViewBag.TinhDiem = model.DiemTB;
        return View("Index");
    }
    
}