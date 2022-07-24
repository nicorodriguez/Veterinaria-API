using Microsoft.EntityFrameworkCore;
using Veterinaria_API.Entities;

namespace Veterinaria_API
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options): base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DateTime dateTime = DateTime.Now;

            var client1 =
                new Client()
                {
                    Id = 1,
                    Name = "Luis",
                    LastName = "Lorenzetti",
                    Email = "loren_luis@gmail.com"
                };

            var client2 =
                new Client()
                {
                    Id = 2,
                    Name = "Mónica",
                    LastName = "Barrientos",
                    Email = "monica_barrientos_39@gmail.com"
                };

            modelBuilder.Entity<Client>()
                .HasData(
                    client1,
                    client2
                );

            modelBuilder.Entity<Patient>()
                .HasData(
                    new Patient()
                    {
                        Id = 1,
                        Name = "Cascote",
                        Type = "Perro",
                        Breed = "Labrador",
                        AdmissionDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.AddDays(-2).Day),
                        DischargeDate = null,
                        Symptoms = "Inanición, falta de movilidad",
                        ClientId = client1.Id,
                    },
                    new Patient()
                    {
                        Id = 2,
                        Name = "Pelusa",
                        Type = "Gato",
                        Breed = "Persa",
                        AdmissionDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day),
                        DischargeDate = null,
                        Symptoms = "A determinar",
                        ClientId = client2.Id,
                    }
                );
        }
    }
}
