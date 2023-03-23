using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult Index()
        {
            var context = ClinicContext.getInstance();
            var repo = new PatientRepository(context);
            var patients = repo.GetAll();
            return View(patients);
        }
        [HttpPost]
        public ActionResult Add(Patient patient)
        {
            var context = ClinicContext.getInstance();
            var repo = new PatientRepository(context);
            repo.Add(patient);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
    }
}