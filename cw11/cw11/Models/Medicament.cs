using System;
using System.ComponentModel.DataAnnotations;

namespace cw11.Models {

    public class Medicament {

        [Key]
        public int IdMedicament { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

        public Medicament() {
        }
    }
}
