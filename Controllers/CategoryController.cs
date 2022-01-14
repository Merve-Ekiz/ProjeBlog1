using Bussiness.Concreate;
using Bussiness.ValidationFluent;
using Dal.EntityFramework;
using EntityLayer.Concreate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjeBlog1.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());
        public IActionResult CategoryListe()
        {
            var values = cm.Getlist();
            return View(values);
        }
        [HttpGet]
        public IActionResult CategoryEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CategoryEkle(Category p)
        {
            CategoryValidator cv = new CategoryValidator();
            ValidationResult results = cv.Validate(p);
            if (results.IsValid)
            {
                
                cm.TAdd(p);
                return RedirectToAction("CategoryListe", "Category");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult DeleteCategory(int id)
        {
            var CategoryValue = cm.GetlistById(id);
            cm.TDelete(CategoryValue);
            return RedirectToAction("CategoryListe");
        }
        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            var CategoryValue = cm.GetlistById(id);
            return View(CategoryValue);
        }
        [HttpPost]
        public IActionResult EditCategory(Category p)
        {
            cm.TUpdate(p);
            return RedirectToAction("CategoryListe");
        }

    }
}
