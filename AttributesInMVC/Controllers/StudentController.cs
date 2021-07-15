using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AttributesInMVC.Models;

namespace AttributesInMVC.Controllers
{
    //before starting refer STUDENT.cs because it has attributes
    public class StudentController : Controller
    {
        STUDENTDBEntities db = new STUDENTDBEntities();
        public ActionResult Index()
        {
            var x = db.STUDENTs.ToList();       //list of students fetched from database ->STUDENT model
            return View(x);
        }

        [HttpGet]
        public ActionResult Details(int studentid)
        {
            var y = db.STUDENTs.FirstOrDefault(x => x.id == studentid);
            return View(y);
        }
    }
}