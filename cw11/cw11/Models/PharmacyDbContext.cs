using System;
using Microsoft.EntityFrameworkCore;

namespace cw11.Models {

    public class PharmacyDbContext : DbContext{

        public DbSet<Patient> Patient { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Medicament> Medicament { get; set; }
        public DbSet<GetPrescription_Medicamant> GetPrescription_Medicamant { get; set; }

        public PharmacyDbContext() {
        }

        public PharmacyDbContext(DbContextOptions options) : base(options){

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Patient>((builder) => {
                builder.HasData(
                    new Patient { IdPatient = 1, FirstName = "Jan", LastName = "Kowalski", Birthdate = DateTime.Now},
                    new Patient { IdPatient = 2, FirstName = "Ania", LastName = "Andrzejewska", Birthdate = DateTime.Now },
                    new Patient { IdPatient = 3, FirstName = "Ola", LastName = "Sparc", Birthdate = DateTime.Now },
                    new Patient { IdPatient = 4, FirstName = "Kasia", LastName = "Kowalczyk", Birthdate = DateTime.Now },
                    new Patient { IdPatient = 5, FirstName = "Bartosz", LastName = "Nowak", Birthdate = DateTime.Now }
                );
            });

            modelBuilder.Entity<Doctor>((builder) => {
                builder.HasData(
                    new Doctor { IdDoctor = 1, FirstName = "Anna", LastName = "Mordacz", Email = "a.mordacz@gmail.com" },
                    new Doctor { IdDoctor = 2, FirstName = "Tomasz", LastName = "Tomaczowski", Email = "t.tomaczowski@gmail.com" },
                    new Doctor { IdDoctor = 3, FirstName = "Andrzej", LastName = "Andrzejewski", Email = "a.andrzejewski@gmail.com" }
                );
            });

            modelBuilder.Entity<Prescription>((builder) => {
                builder.HasData(
                    new Prescription { IdPrescription = 1, Date = DateTime.Now, DueDate = DateTime.Now, IdPatient = 1, IdDoctor = 1 },
                    new Prescription { IdPrescription = 2, Date = DateTime.Now, DueDate = DateTime.Now, IdPatient = 2, IdDoctor = 1 },
                    new Prescription { IdPrescription = 3, Date = DateTime.Now, DueDate = DateTime.Now, IdPatient = 3, IdDoctor = 2 },
                    new Prescription { IdPrescription = 4, Date = DateTime.Now, DueDate = DateTime.Now, IdPatient = 4, IdDoctor = 3 },
                    new Prescription { IdPrescription = 5, Date = DateTime.Now, DueDate = DateTime.Now, IdPatient = 5, IdDoctor = 3 }
                );
            });

            modelBuilder.Entity<Medicament>((builder) => {
                builder.HasData(
                    new Medicament { IdMedicament = 1, Name = "Fervex", Description = "Lek na goraczke" , Type = "Przeciwgoraczkowy" },
                    new Medicament { IdMedicament = 2, Name = "Gripex", Description = "Lek na goraczke", Type = "Przeciwgoraczkowy" },
                    new Medicament { IdMedicament = 3, Name = "Acutol", Description = "Lek na odciski", Type = "Leczniczy" },
                    new Medicament { IdMedicament = 4, Name = "Witamina C", Description = "Lek na odpornosc", Type = "Wzmacniajacy" },
                    new Medicament { IdMedicament = 5, Name = "Witamina B", Description = "Lek na odpornosc" , Type = "Wzmacniajacy" }
                );
            });

            modelBuilder.Entity<GetPrescription_Medicamant>((builder) => {
                builder.HasKey(a => new {
                    a.IdMedicament,
                    a.IdPrescription
                });

                builder.HasData(
                    new GetPrescription_Medicamant { IdMedicament = 1, IdPrescription = 1, Dose = 2, Details = "2 razy dziennie"},
                    new GetPrescription_Medicamant { IdMedicament = 2, IdPrescription = 2, Dose = 1, Details = "1 raz dziennie" },
                    new GetPrescription_Medicamant { IdMedicament = 3, IdPrescription = 3, Dose = 3, Details = "3 razy dziennie" },
                    new GetPrescription_Medicamant { IdMedicament = 4, IdPrescription = 4, Dose = 2, Details = "2 razy dziennie" },
                    new GetPrescription_Medicamant { IdMedicament = 5, IdPrescription = 5, Dose = 2, Details = "2 razy dziennie" }
                );
            });
        }
    }
}
