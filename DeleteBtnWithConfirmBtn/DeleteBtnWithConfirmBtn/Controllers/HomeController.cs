using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DeleteBtnWithConfirmBtn.Models;

namespace DeleteBtnWithConfirmBtn.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        NorthwindEntities _db = new NorthwindEntities();

        public ActionResult Index()
        {
            var allEmployees = _db.Employees.ToList();
            return View(allEmployees);
        }

        public ActionResult Delete(int id)
        {

            Employee willDeleteEmployee = _db.Employees.Find(id);
            _db.Employees.Remove(willDeleteEmployee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}