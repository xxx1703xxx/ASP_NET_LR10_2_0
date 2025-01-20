using LR10.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

public class ConsultationController : Controller
{
    [HttpGet]
    public IActionResult Register()
    {
        ViewBag.Products = new List<string> { "JavaScript", "C#", "Java", "Python", "Основи" };
        return View();
    }

    [HttpPost]
    public IActionResult Register(ConsultationRequest model)
    {
        if (model.Product == "Основи" && model.PreferredDate.DayOfWeek == DayOfWeek.Monday)
        {
            ModelState.AddModelError("Product", "Консультація щодо продукту «Основи» не може проходити по понеділках.");
        }

        if (ModelState.IsValid)
        {
            return RedirectToAction("Success");
        }

        ViewBag.Products = new List<string> { "JavaScript", "C#", "Java", "Python", "Основи" };
        return View(model);
    }

    public IActionResult Success()
    {
        return View();
    }
}
