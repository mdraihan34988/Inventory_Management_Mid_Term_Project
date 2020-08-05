using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ATP2_Project.Models.DataViewModel;
using ATP2_Project.Models;

namespace ATP2_Project.Controllers
{
    public class TestController : Controller
    {
        Inventory_ManagementEntities inm = new Inventory_ManagementEntities();
        // GET: Test
        public ActionResult Index()
        {
            CategoryViewModel viewModel= new CategoryViewModel();
            viewModel.catagories = inm.Catagories.ToList();
            return View(viewModel);
        }

        public ActionResult List()
        {
            CategoryViewModel viewModel = new CategoryViewModel();
            viewModel.catagories = inm.Catagories.ToList();
            return View(viewModel);
        }
    }
}