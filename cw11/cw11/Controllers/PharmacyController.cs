using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.DTOs.Requests;
using cw11.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace cw11.Controllers {

    [Route("api/pharmacy")]
    [ApiController]
    public class PharmacyController :ControllerBase {
        private readonly PharmacyDbContext _context;

        public PharmacyController(PharmacyDbContext context) {
            this._context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors() {
            return Ok(_context.Doctor.ToList());
        }

        [HttpPut]
        public IActionResult AddDoctor(AddDoctorRequest addDoctorRequest) {
            _context.Doctor.Add(new Doctor { IdDoctor = addDoctorRequest.IdDoctor, FirstName = addDoctorRequest.FirstName, LastName = addDoctorRequest.LastName, Email = addDoctorRequest.Email });
            return Ok("Doktor dodany");
        }

        [HttpPost]
        public IActionResult ModifyDoctor(ModifyDoctorRequest modifyDoctorRequest) {
            var list = _context.Doctor.Where(e => e.IdDoctor == modifyDoctorRequest.IdDoctor).ToList();
            if (list.Count() == 0) return BadRequest(300);
            list.First().FirstName = modifyDoctorRequest.FirstName;
            list.First().LastName = modifyDoctorRequest.LastName;
            list.First().Email = modifyDoctorRequest.Email;
            _context.SaveChanges();
            return Ok("Doktor zmodyfikowany");
        }

        [HttpDelete]
        public IActionResult DeleteDoctor(DeleteDoctorRequest deleteDoctorRequest) {
            var prescriptionList = _context.Prescription.Where(e => e.IdDoctor == deleteDoctorRequest.IdDoctor).ToList();
            ArrayList prescription_MedicamantList = new ArrayList();
            foreach(Prescription prescription in prescriptionList) {
                prescription_MedicamantList.Add(_context.GetPrescription_Medicamant.Where(e => e.IdPrescription == prescription.IdPrescription));
            }

            foreach(GetPrescription_Medicamant prescription_Medicamant in prescription_MedicamantList) {
                _context.Remove(prescription_Medicamant);
            }

            foreach(Prescription prescription in prescriptionList) {
                _context.Remove(prescription);
            }

            _context.Remove(_context.Doctor.Where(e => e.IdDoctor == deleteDoctorRequest.IdDoctor).ToList().First());
            _context.SaveChanges();

            return Ok("Usunieto doktora wraz ze wszystkimi receptami wystawionymi przez tego doktora");
        }
    }
}
