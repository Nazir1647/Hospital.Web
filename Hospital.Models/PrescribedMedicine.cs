using System.ComponentModel.DataAnnotations;

namespace Hospital.Models
{
    public class PrescribedMedicine
    {
        [Key]
        public int Id { get; set; }
        public Medicine Medicine { get; set; }
        public PatientReport patientReport { get; set; }
    }
}