using System;
using System.ComponentModel.DataAnnotations;

namespace cw11.DTOs.Requests {

    public class AddDoctorRequest {
        [Required]
        public int IdDoctor { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }

        public AddDoctorRequest() {
        }
    }
}
