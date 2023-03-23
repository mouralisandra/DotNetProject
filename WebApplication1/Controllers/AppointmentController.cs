using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class AppointmentController : Controller
    {
        // GET: Appointment
        public ActionResult Index()
        {
            var context = ClinicContext.getInstance();
            var repo = new AppointmentRepository(context);
            var appointments = repo.GetAll();
            return View(appointments);
        }
    }
}