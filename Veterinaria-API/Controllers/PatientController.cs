using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinaria_API.Entities;

namespace Veterinaria_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {

        [HttpGet]
        public ActionResult<List<Patient>> Get()
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

            return Ok(new List<Patient>()
            {
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
                    Client = client1
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
                    Client = client2
                }
            });
        }
    }
}
