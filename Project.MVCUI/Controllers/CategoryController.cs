using Project.BLL.DesingPatterns.GenericRepository.ConcRepo;
using Project.MVCUI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.MVCUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryRepository _cRep;

        public CategoryController()
        {
            _cRep = new CategoryRepository();
        }

        // GET: Category
        public ActionResult ListCategories()
        {
            CategoryVM categoryVM = new CategoryVM
            {
                Categories = _cRep.GetActives()
            };
            return View(categoryVM);
        }
    }
}