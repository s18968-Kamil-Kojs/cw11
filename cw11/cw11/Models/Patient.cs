using System;
using System.ComponentModel.DataAnnotations;

namespace cw11.Models {

    public class Patient {

        [Key]
        public int IdPatient { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }

        public Patient() {
        }
    }
}
