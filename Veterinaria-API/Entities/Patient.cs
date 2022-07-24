namespace Veterinaria_API.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public DateTime? AdmissionDate { get; set; }
        public DateTime? DischargeDate { get; set; }
        public string Symptoms { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
