using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATP2_Project.Models;
using ATP2_Project.Models.DataViewModel;

namespace ATP2_Project.Controllers
{
    public class CategoryController : Controller
    {
        Inventory_ManagementEntities inm = new Inventory_ManagementEntities();
        // GET: Category
        [HttpGet]
        public ActionResult Index()
        {
            CategoryViewModel viewModel = new CategoryViewModel();
            viewModel.catagories = inm.Catagories.ToList();
            return View(viewModel);
        }
        [HttpPost]
        public RedirectToRouteResult Index(Catagory catagory)
        {
            //if (ModelState.IsValid)
            //{
                inm.Catagories.Add(catagory);
                inm.SaveChanges();
            //}
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult List()
        {
            CategoryViewModel viewModel = new CategoryViewModel();
            viewModel.catagories = inm.Catagories.ToList();
            return View(viewModel);
        }

        
    }
}