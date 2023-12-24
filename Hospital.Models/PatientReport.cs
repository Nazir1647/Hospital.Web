using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class PatientReport
    {
        [Key]
        public int Id { get; set; }
        public string Diagnose { get; set; }
        public string MedicineName { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public ICollection<PrescribedMedicine> PrescribedMedicines { get; set; }
    }
}