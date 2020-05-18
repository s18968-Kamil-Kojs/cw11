using System;
using System.ComponentModel.DataAnnotations;

namespace cw11.DTOs.Requests {
    public class DeleteDoctorRequest {
        [Required]
        public int IdDoctor { get; set; }

        public DeleteDoctorRequest() {
        }
    }
}
