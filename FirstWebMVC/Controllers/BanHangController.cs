using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
using FirstWebMVC.Models.Entities;

namespace FirstWebMVC.Controllers;

public class BanHangController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(BanHang model)
    {
        if (ModelState.IsValid)
        {
            model.TongHD = model.SoLuong * model.DonGia;
            ViewBag.TongHD = model.TongHD;
        }

        return View(model);
    }
}