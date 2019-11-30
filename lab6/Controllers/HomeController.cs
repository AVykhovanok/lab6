using lab6.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace lab6.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();
        public ActionResult Index()
        {
            IEnumerable<Procedure> procedures = db.Procedures;
            ViewBag.Procedures = procedures;
            return View();
        }

        [HttpGet]
        public ActionResult MakeAnAppointment(int id)
        {
            ViewBag.PatientId = id;
            return View();
        }

        [HttpPost]
        public string MakeAnAppointment(Patient patient)
        {
            patient.Date = DateTime.Now;
            db.Patients.Add(patient);
            db.SaveChanges();
            return patient.PatientFirstName + patient.PatientSecondName  + " успішно записаний!";
        }
    }
}