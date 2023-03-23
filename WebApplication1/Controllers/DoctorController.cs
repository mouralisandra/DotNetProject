using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index()
        {
            var context = ClinicContext.getInstance();
            var repo = new DoctorRepository(context);
            var doctors = repo.GetAll();
            return View(doctors);
        }
        public ActionResult Delete(Doctor doctor)
        {
            var context = ClinicContext.getInstance();
            var repo = new DoctorRepository(context);
            repo.Remove(doctor);
            return RedirectToAction(nameof(Index));
        }


        [HttpPost]
        public ActionResult Add(Doctor doctor)
        {
            
            var context = ClinicContext.getInstance();
            var repo = new DoctorRepository(context);
            repo.Add(doctor);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
    }
}